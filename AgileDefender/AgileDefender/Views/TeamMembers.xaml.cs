using AgileDefender.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AgileDefender.Views
{
    public partial class TeamMembers : ContentPage
    {
        public TeamMembers()
        {
            InitializeComponent();

            this.Title = PageResources.DefaultPageTitle;

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(32.8946723, -96.9774144), Distance.FromMiles(1)));

            var position = new Position(32.8946723, -96.9774144); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.SearchResult,
                Position = position,
                Label = "Neudesic",
                Address = "Starbucks"
            };
            MyMap.Pins.Add(pin);

            // CJP TODO, need add MediaPlayer for pop sound playback foreach teamMember
            
        }
    }
}
