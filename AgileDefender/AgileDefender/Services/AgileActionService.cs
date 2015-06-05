using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgileDefender.Models;

namespace AgileDefender.Services
{
    public class AgileActionService : IAgileActionService
    {
        public ObservableCollection<AgileAction> GetTestData()
        {
            var agileActionItems = new ObservableCollection<AgileAction>();
            
            agileActionItems.Add(new AgileAction("Daily Scrum", "https://xamarindevdayscdn.blob.core.windows.net/cdn/scrum_gray.png"));
            agileActionItems.Add(new AgileAction("User Stories", "https://xamarindevdayscdn.blob.core.windows.net/cdn/user_stories_gray.png"));
            agileActionItems.Add(new AgileAction("Assigned Open Bugs", "https://xamarindevdayscdn.blob.core.windows.net/cdn/bugs_gray.png"));
            agileActionItems.Add(new AgileAction("Team Members", "https://xamarindevdayscdn.blob.core.windows.net/cdn/team_gray.png"));
            agileActionItems.Add(new AgileAction("App Settings", "https://xamarindevdayscdn.blob.core.windows.net/cdn/settings_gray.png"));

            return agileActionItems;
        }
    }
}
