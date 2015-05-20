using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Neudesic.AgileDefender.Configuration;
using Xamarin;

namespace Neudesic.AgileDefender.Droid
{
    [Activity(Label = "Neudesic Tastings", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            Insights.Initialize(AppConstants.XamarinInsightsApiKey, ApplicationContext);
        }

    }
}

