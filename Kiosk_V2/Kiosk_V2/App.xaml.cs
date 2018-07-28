using Kiosk_V2.Helpers;
using Microsoft.Identity.Client;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Kiosk_V2
{
	public partial class App : Application
	{
        public static RESTManager RManager { get; set; }
        public static PublicClientApplication AuthenticationClient { get; set; }

        // TODO #1: Add Azure AD B2C tenant information.
        public static string ClientId = "8ca648fd-2dc3-4ff1-aa4c-e9bd5543f2d0";
        public static string SignUpSignInPolicy = "B2C_1_SignInSignUp";
        public static string[] Scopes = { ClientId };
        public static string Authority = "https://login.microsoftonline.com/momentsapp.onmicrosoft.com/";

        public App ()
		{
			InitializeComponent();
            AuthenticationClient = new PublicClientApplication(ClientId);

            MainPage = new MainPage();
            RManager = new RESTManager();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
