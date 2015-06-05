using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;
using Xamarin.Forms;

using AgileDefender.Helpers;

namespace AgileDefender.Views
{
    public partial class UserSettings : ContentPage
    {
        public UserSettings()
        {
            InitializeComponent();

            var handle = Insights.TrackTime("UserSettings");
            handle.Start();

            this.Title = PageResources.DefaultPageTitle;
            //this.BindingContext = new SignInViewModel(Navigation);

            handle.Stop();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
