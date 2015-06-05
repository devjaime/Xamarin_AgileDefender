using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDefender.Helpers
{
    public static class PageResources
    {
        public static string DefaultPageTitle = " Agile Defender";

        public static string ActionDailyScrumTitle = "Daily Scrum";
        public static string ActionDailyScrumImage = "https://xamarindevdayscdn.blob.core.windows.net/cdn/scrum_gray.png";

        public static string ActionUserStoriesTitle = "User Stories";
        public static string ActionUserStoriesImage = "https://xamarindevdayscdn.blob.core.windows.net/cdn/user_stories_gray.png";

        public static string ActionAssignedOpenBugsTitle = "Assigned Open Bugs";
        public static string ActionAssignedOpenBugsImage = "https://xamarindevdayscdn.blob.core.windows.net/cdn/bugs_gray.png";

        public static string ActionTeamMembersTitle = "Team Members";
        public static string ActionTeamMembersImage = "https://xamarindevdayscdn.blob.core.windows.net/cdn/team_gray.png";

        public static string ActionAppSettingsTitle = "App Settings";
        public static string ActionAppSettingsImage = "https://xamarindevdayscdn.blob.core.windows.net/cdn/settings_gray.png";
    }

    public enum PageResourceName
    {
        DailyScrum = 0,
        UserStories = 1,
        AssignedOpenBugs = 2,
        TeamMembers = 3,
        AppSettings = 4
    }

}
