using Neudesic.AgileDefender.Configuration;
using Neudesic.AgileDefender.Helpers;
using Xamarin.Forms;

namespace Neudesic.AgileDefender.ViewModels
{
    public class TakeSurveyViewModel: BaseViewModel
    {
        private readonly INavigation _navigation;

        public TakeSurveyViewModel(INavigation navigation)
        {
            _navigation = navigation;

            _surveyUrl = string.Format(AppConstants.NintexUrl, Settings.UserEmail);
        }

        private string _surveyUrl;
        public string SurveyUrl
        {
            get { return _surveyUrl; }
            set { _surveyUrl = value; OnPropertyChanged("SurveyUrl"); }
        }
    }
}
