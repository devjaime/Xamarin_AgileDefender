using Neudesic.AgileDefender.Configuration;
using Neudesic.AgileDefender.ViewModels;
using Xamarin;
using Xamarin.Forms;

namespace Neudesic.AgileDefender.Views
{
    public partial class SignInPage
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
                DisplayAlert("Sign In Failed", "Please check the Event Code.", "Ok");
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Insights.Track(AppConstants.SignInPage);
        }
    }
}
