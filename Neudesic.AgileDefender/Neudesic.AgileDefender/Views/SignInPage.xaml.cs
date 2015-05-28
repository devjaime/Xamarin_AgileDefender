using Xamarin;
using Xamarin.Forms;

using Neudesic.AgileDefender.Configuration;
using Neudesic.AgileDefender.ViewModels;

namespace Neudesic.AgileDefender.Views
{
    public partial class SignInPage : ContentPage
    {
        public SignInViewModel ViewModel
        {
            get { return BindingContext as SignInViewModel; }
            set { BindingContext = value; }
        }

        public SignInPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            ViewModel = new SignInViewModel(Navigation);

            MessagingCenter.Subscribe<SignInViewModel>(this, "SignInFailed", sender =>
            {
                DisplayAlert("Sign In Failed", "Username or Password is incorrect", "Ok");
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Insights.Track(AppConstants.SignInPage);
        }
    }
}
