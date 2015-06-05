using System.Collections.ObjectModel;

using AgileDefender.Models;
using AgileDefender.Setup;
using AgileDefender.Services;

namespace AgileDefender.ViewModels
{
    public class ActionViewModel : BaseViewModel
    {
        public ActionViewModel()
        {
            var agileService = ServiceLocator.GetService<IAgileActionService>();
            
            // TODO Implement local and/or remote data service
            AgileActionItems = agileService.GetTestData();
        }

        public ObservableCollection<AgileAction> AgileActionItems { get; private set; }
    }
}
