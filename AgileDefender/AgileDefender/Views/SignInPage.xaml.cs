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

            Insights.Track("SignInPage");

            this.Title = PageResources.DefaultPageTitle;
            this.BindingContext = new SignInViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
