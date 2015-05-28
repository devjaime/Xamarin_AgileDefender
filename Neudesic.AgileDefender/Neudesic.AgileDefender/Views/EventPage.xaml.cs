using Neudesic.AgileDefender.Configuration;
using Neudesic.AgileDefender.ViewModels;

using Xamarin;
using Xamarin.Forms;

namespace Neudesic.AgileDefender.Views
{
    public partial class EventPage : ContentPage
    {
        public EventViewModel ViewModel
        {
            get { return BindingContext as EventViewModel; }
            set { BindingContext = value; }
        }

        public EventPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetBackButtonTitle(this, string.Empty);

            ViewModel = new EventViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Insights.Track(AppConstants.EventPage);
        }

    }
}
