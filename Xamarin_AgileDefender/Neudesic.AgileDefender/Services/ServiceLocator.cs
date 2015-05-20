namespace Neudesic.AgileDefender.Services
{
    public static class ServiceLocator
    {
        private static ITastingService _tastingService;

        public static ITastingService TastingService
        {
            get { return _tastingService ?? (_tastingService = new TastingService()); }
        }
    }
}
