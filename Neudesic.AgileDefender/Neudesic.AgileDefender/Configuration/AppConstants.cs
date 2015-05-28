namespace Neudesic.AgileDefender.Configuration
{
    public static class AppConstants
    {
        // REST service endpoint base URI
        public const string TastingBaseSvcUrl = "https://tastings.neudesic.com/api";

        // Nintex Url
        public const string NintexUrl = "https://forms.nintex.com/FormHost.aspx?id=JJL92EKVkEBWwiPju6RGzpkfGIR8VZAXuCCzSb-msnRbUsdDq5uAxyN0VcCblGm0ShHPTz6kxaOe1rLyzUByMB6SCjMXyFRPF5_E0ISuoBAOqsJairmY-IvcJTiR77es&email={0}";
        
        // Xamarin.Insights
        public const string XamarinInsightsApiKey = "bfe1e7154c1264c699675e9d4928b5af9269b55f";
        public const string TimeToLoadTastingEvent = "TimeToLoadTastingEvent";
        public const string TimeToGetUser = "TimeToGetUser";
        public const string TimeToRegisterUser = "TimeToRegisterUser";
        public const string TimeToSubmitVote = "TimeToSubmitVote";
        public const string SignInPage = "SignInPage";
        public const string EventPage = "EventPage";
        public const string SurveyPage = "SurveyPage";
        public const string TastingItemListPage = "TastingItemListPage";
        public const string TastingItemDetailsPage = "TastingItemDetailsPage";
        public const string ExecuteRefreshCommand = "ExecuteRefreshCommand";
        public const string ExecuteVoteCommand = "ExecuteVoteCommand";
        public const string GetUser = "GetUser";
        public const string SubmitVote = "SubmitVote";

        public const string ListItemPlaceholderImg = "Images/ListPlaceholder";
        public const string ItemListPageTitle = "Discover Wines";
        public const int DefaultTestingMetricId = 7;
    }
}
