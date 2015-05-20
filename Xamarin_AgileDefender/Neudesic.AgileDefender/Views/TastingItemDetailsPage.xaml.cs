using Neudesic.Tastings.Configuration;
using Neudesic.Tastings.Models;
using Neudesic.Tastings.ViewModels;
using Xamarin;
using Xamarin.Forms;

namespace Neudesic.Tastings.Views
{
    public partial class TastingItemDetailsPage : ContentPage
    {
        public TastingItemDetailsViewModel ViewModel
        {
            get { return BindingContext as TastingItemDetailsViewModel; }
            set { BindingContext = value; }
        }

        public TastingItemDetailsPage(TastingItem tastingItem)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);

            ViewModel = new TastingItemDetailsViewModel(Navigation, tastingItem);

            //VoteDecrement.GestureRecognizers.Add(new TapGestureRecognizer(sender =>
            //{
            //    VoteDecrement.Opacity = 0.6;
            //    VoteDecrement.FadeTo(1);
            //}));

            //VoteIncrement.GestureRecognizers.Add(new TapGestureRecognizer(sender =>
            //{
            //    VoteIncrement.Opacity = 0.6;
            //    VoteIncrement.FadeTo(1);
            //}));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<TastingItemDetailsViewModel>(this, "SubmitVoteFailed", sender =>
            {
                DisplayAlert("Error", "Your vote cannot be submitted at this time.", "Ok");
            });

            MessagingCenter.Subscribe<TastingItemDetailsViewModel>(this, "SubmitVoteSucceeded", sender =>
            {
                DisplayAlert("Success", "Your vote was successfully submitted.", "Ok");
            });
            
            Insights.Track(AppConstants.TastingItemDetailsPage);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<TastingItemDetailsViewModel>(this, "SubmitVoteFailed");
            MessagingCenter.Unsubscribe<TastingItemDetailsViewModel>(this, "SubmitVoteSucceeded");
        }
    }
}
