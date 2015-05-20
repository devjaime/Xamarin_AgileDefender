using Neudesic.Tastings.Configuration;
using Neudesic.Tastings.ViewModels;
using Xamarin;
using Xamarin.Forms;

namespace Neudesic.Tastings.Views
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
