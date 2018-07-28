using Kiosk_V2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kiosk_V2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Emotion : ContentPage
	{
		public Emotion ()
		{
			InitializeComponent ();
		}
        async void btn_Clicked(object sender, EventArgs e)
        {
            try
            {
                String Image = await Utilities.getCamera();
                String res = await App.RManager.ReadEmotion(Convert.FromBase64String(Image));

                await DisplayAlert("Emotion Detected", res, "OK");
            }
            catch (Exception ex) { }
        }
    }
}