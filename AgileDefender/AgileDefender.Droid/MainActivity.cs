using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin;
using Toasts.Forms.Plugin.Droid;

namespace AgileDefender.Droid
{
    [Activity(Label = "Agile Defender", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Xamarin Insights init for Android
            Insights.Initialize("5b2e619fbdf4ec79ff1a8097b00e732a8b212ab5", ApplicationContext);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.FormsMaps.Init(this, bundle);

            // Xamarin Forms Toast init for Android
            ToastNotificatorImplementation.Init();

            LoadApplication(new App());
        }
    }
}

