using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kiosk_V2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public async void LoginButton_Clicked(object sender, EventArgs e)
        {
           /* try
            {
                var authenticationResult = await App.AuthenticationClient.AcquireTokenAsync(App.Scopes,
                    "",
                    UiOptions.SelectAccount,
                    string.Empty,
                    null,
                    App.Authority,
                    App.SignUpSignInPolicy);
                await Navigation.PushModalAsync(new AuthenticationSuccessfulPage(authenticationResult));
                // await Navigation.PushAsync(new AuthenticationSuccessfulPage(authenticationResult));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Authenticating", ex.Message, "OK");
            }*/
        }
    }
}

