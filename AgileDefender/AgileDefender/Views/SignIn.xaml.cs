using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin;
using Xamarin.Forms;

using AgileDefender.ViewModels;
using AgileDefender.Helpers;

namespace AgileDefender.Views
{
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();

            //Insights.Track("SignIn");
            var handle = Insights.TrackTime("SignIn");
            handle.Start();

            this.Title = PageResources.DefaultPageTitle;
            this.BindingContext = new SignInViewModel(Navigation);

            handle.Stop();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
