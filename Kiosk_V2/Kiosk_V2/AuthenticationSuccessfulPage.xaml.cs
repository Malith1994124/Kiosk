using Microsoft.Identity.Client;
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
    public partial class AuthenticationSuccessfulPage : ContentPage
    {
        public string UserId { get; set; }
        public string ExpiresOn { get; set; }

      /*  public AuthenticationSuccessfulPage(AuthenticationResult authenticationResult)
        {
            InitializeComponent();

            UserId = $"User Id: {authenticationResult.User.UniqueId}";
            ExpiresOn = $"Token Expires {authenticationResult.ExpiresOn.ToString()}";

            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await App.AuthenticationClient.AcquireTokenSilentAsync(App.Scopes,
             string.Empty,
             App.Authority,
             App.SignUpSignInPolicy,
             false);
        }
        */
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Emotion());
            await Navigation.PushModalAsync(new Emotion());
        }
    }
}