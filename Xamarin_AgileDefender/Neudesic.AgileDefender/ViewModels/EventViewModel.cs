using System.Threading.Tasks;
using System.Windows.Input;
using Neudesic.Tastings.Services;
using Neudesic.Tastings.Views;
using Xamarin.Forms;

namespace Neudesic.Tastings.ViewModels
{
    public class EventViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;

        public EventViewModel(INavigation navigation)
        {
            _navigation = navigation;

            var tastingService = ServiceLocator.TastingService;
            var tastingInfo = tastingService.TastingEvent.Info;

            _backgroundImgUrl = tastingInfo.BackgroundImageUrl;
            _title = tastingInfo.HeaderText;
        }

        private string _backgroundImgUrl;
        public string BackgroundImgUrl
        {
            get { return _backgroundImgUrl; }
            set { _backgroundImgUrl = value; OnPropertyChanged("BackgroundImgUrl"); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged("Title"); }
        }
        
        private Command _joinEventCommand;

        private Command _takeSurveyCommand;

        public ICommand JoinEventCommand
        {
            get { return _joinEventCommand ?? (_joinEventCommand = new Command(async () => await ExecuteJoinEventCommand())); }
        }

        public ICommand TakeSurveyCommand
        {
            get { return _takeSurveyCommand ?? (_takeSurveyCommand = new Command(async () => await ExecuteTakeSurveyCommand())); }
        }

        private async Task ExecuteJoinEventCommand()
        {
            var listPage = new TastingItemListPage();
            await _navigation.PushAsync(listPage);
        }

        private async Task ExecuteTakeSurveyCommand()
        {
            var surveyPage = new TakeSurveyPage();
            await _navigation.PushAsync(surveyPage);
        }
    }
}
