using Neudesic.Tastings.Configuration;
using Neudesic.Tastings.Models;
using Neudesic.Tastings.ViewModels;
using Xamarin;
using Xamarin.Forms;

namespace Neudesic.Tastings.Views
{
    public partial class TastingItemListPage : ContentPage
    {
        public TastingItemListViewModel ViewModel
        {
            get { return BindingContext as TastingItemListViewModel; }
            set { BindingContext = value; }
        }

        public TastingItemListPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetBackButtonTitle(this, string.Empty);

            ViewModel = new TastingItemListViewModel(Navigation);

            ItemsListView.ItemTapped += (sender, args) =>
            {
                if (ItemsListView.SelectedItem == null)
                    return;

                var detailsPage = new TastingItemDetailsPage(args.Item as TastingItem);
                Navigation.PushAsync(detailsPage);

                ItemsListView.SelectedItem = null;
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Insights.Track(AppConstants.TastingItemListPage);
        }
    }
}
