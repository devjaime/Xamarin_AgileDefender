using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

using AgileDefender.Helpers;
using AgileDefender.Services;

namespace AgileDefender.Views
{
    public partial class TeamMembers : ContentPage
    {
        public TeamMembers()
        {
            InitializeComponent();

            this.Title = PageResources.DefaultPageTitle;

            // CJP TODO, need to move team member service to ioc container
            TeamMemberService service = new TeamMemberService();
            var teamMemberList = service.GetTestData();

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(32.8946723, -96.9774144), Distance.FromMiles(1)));

            foreach (var teamMember in teamMemberList)
            {
                var position = new Position(teamMember.UserLocation.Latitude, teamMember.UserLocation.Longitude); // Latitude, Longitude
                var pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = position,
                    Label = teamMember.User.Name,
                    Address = teamMember.UserLocation.AddressName
                };

                MyMap.Pins.Add(pin);

                // CJP TODO, need add MediaPlayer for pop sound playback foreach teamMember
            }

        }
    }
}
