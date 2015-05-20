using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Neudesic.AgileDefender.Configuration;
using Neudesic.AgileDefender.Helpers;
using Neudesic.AgileDefender.Models;
using Neudesic.AgileDefender.Services;
using Xamarin;
using Xamarin.Forms;

namespace Neudesic.AgileDefender.ViewModels
{
    public class TastingItemListViewModel : BaseViewModel
    {
        private readonly ITastingService _tastingService;
        private readonly INavigation _navigation;

        public ObservableCollection<TastingItem> TastingItems { get; set; }

        public TastingItemListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _tastingService = ServiceLocator.TastingService;

            // TODO: Refactor this to call service again in case TastingEvent is not anymore in memory
            var tastingItems = _tastingService.TastingEvent.TastingItems;

            TastingItems = new ObservableCollection<TastingItem>(tastingItems);
        }

        private Command _refreshCommand;

        public Command RefreshCommand
        {
            get
            {
                return _refreshCommand ?? (_refreshCommand = new Command(async () => await ExecuteRefreshCommand(), () => !IsRefreshing));
            }
        }

        private async Task ExecuteRefreshCommand()
        {
            if (IsRefreshing)
                return;

            IsRefreshing = true;
            RefreshCommand.ChangeCanExecute();

            Insights.Track(AppConstants.ExecuteRefreshCommand);

            await _tastingService.LoadTastingEvent(Settings.EventCode);
            if (_tastingService.TastingEvent != null)
            {
                TastingItems.Clear();
                var tastingItems = _tastingService.TastingEvent.TastingItems;
                foreach (var tastingItem in tastingItems)
                {
                    TastingItems.Add(tastingItem);
                }
            }

            IsRefreshing = false;
            RefreshCommand.ChangeCanExecute();
        }
    }
}
