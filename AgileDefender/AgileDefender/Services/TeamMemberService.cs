using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgileDefender.Models;

namespace AgileDefender.Services
{
    public class TeamMemberService : ITeamMemberService
    {
        public ObservableCollection<TeamMemberModel> GetTestData()
        {
            var teamMemberModelList = new ObservableCollection<TeamMemberModel>();

            var user = new User { Name = "Manny Singh" };
            var userLocation = new UserLocationModel { Latitude = 32.8946723, Longitude = -96.9774144, AddressName = "Microsoft Las Colinas" };
            teamMemberModelList.Add(new TeamMemberModel(user, userLocation));

            user = new User { Name = "Chris Palmer" };
            userLocation = new UserLocationModel { Latitude = 32.8946723, Longitude = -96.9774144, AddressName = "Microsoft Las Colinas" };
            teamMemberModelList.Add(new TeamMemberModel(user, userLocation));

            user = new User { Name = "Joseph Baggett" };
            userLocation = new UserLocationModel { Latitude = 32.8959446, Longitude = -96.9597849, AddressName = "Starbucks" };
            teamMemberModelList.Add(new TeamMemberModel(user, userLocation));

            user = new User { Name = "Brent Finney" };
            userLocation = new UserLocationModel { Latitude = 32.8946723, Longitude = -96.9774144, AddressName = "Microsoft Las Colinas." };
            teamMemberModelList.Add(new TeamMemberModel(user, userLocation));

            user = new User { Name = "Landry Kammogne" };
            userLocation = new UserLocationModel { Latitude = 32.89109, Longitude = -96.962958, AddressName = "In Route" };
            teamMemberModelList.Add(new TeamMemberModel(user, userLocation));

            return teamMemberModelList;
        }

    }
}
