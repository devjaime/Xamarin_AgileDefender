using Neudesic.AgileDefender.Configuration;
using Neudesic.AgileDefender.ViewModels;
using Xamarin;
using Xamarin.Forms;

namespace Neudesic.AgileDefender.Views
{
    public partial class TakeSurveyPage
    {
        public TakeSurveyViewModel ViewModel
        {
            get { return BindingContext as TakeSurveyViewModel; }
            set { BindingContext = value; }
        }

        public TakeSurveyPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetBackButtonTitle(this, string.Empty);

            ViewModel = new TakeSurveyViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Insights.Track(AppConstants.SurveyPage);
        }
    }
}