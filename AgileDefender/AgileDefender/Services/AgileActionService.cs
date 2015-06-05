using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgileDefender.Models;
using AgileDefender.Helpers;

namespace AgileDefender.Services
{
    public class AgileActionService : IAgileActionService
    {
        public ObservableCollection<AgileAction> GetTestData()
        {
            var agileActionItems = new ObservableCollection<AgileAction>();

            agileActionItems.Add(new AgileAction(PageResourceName.DailyScrum, PageResources.ActionDailyScrumTitle, PageResources.ActionDailyScrumImage));
            agileActionItems.Add(new AgileAction(PageResourceName.UserStories, PageResources.ActionUserStoriesTitle, PageResources.ActionUserStoriesImage));
            agileActionItems.Add(new AgileAction(PageResourceName.AssignedOpenBugs, PageResources.ActionAssignedOpenBugsTitle, PageResources.ActionAssignedOpenBugsImage));
            agileActionItems.Add(new AgileAction(PageResourceName.TeamMembers, PageResources.ActionTeamMembersTitle, PageResources.ActionTeamMembersImage));
            agileActionItems.Add(new AgileAction(PageResourceName.AppSettings, PageResources.ActionAppSettingsTitle, PageResources.ActionAppSettingsImage));

            return agileActionItems;
        }
    }
}
