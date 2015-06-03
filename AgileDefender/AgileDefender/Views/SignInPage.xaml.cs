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
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();

            //Insights.Track("SignInPage");
            var handle = Insights.TrackTime("SignInPage");
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
