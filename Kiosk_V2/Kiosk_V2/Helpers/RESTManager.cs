using Kiosk_V2.Constants;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk_V2.Helpers
{
    public class RESTManager
    {
        public async Task<string> ReadEmotion(byte[] imageFileStream)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", AppConsts.OCPM_KEY);
                    HttpResponseMessage response;
                    string responseContent;
                    using (var content = new ByteArrayContent(imageFileStream))
                    {
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                        response = await client.PostAsync(AppConsts.COG_URL, content);
                        responseContent = response.Content.ReadAsStringAsync().Result;

                        JToken rootToken = JArray.Parse(responseContent).First;
                        JToken scoresToken = rootToken.Last;
                        JEnumerable<JToken> scoreList = scoresToken.First.Children();
                        String jobjVal = string.Empty;
                        foreach (var score in scoreList) { jobjVal = score.ToString(); }
                        //Issue if multiple emotion have same rating
                        return JsonConvert.DeserializeObject<Dictionary<string, string>>(JObject.Parse("{" + jobjVal + "}").SelectToken("emotion").ToString()).Aggregate((l, r) => Convert.ToDouble(l.Value) > Convert.ToDouble(r.Value) ? l : r).Key;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            return String.Empty;
        }
    }
}
