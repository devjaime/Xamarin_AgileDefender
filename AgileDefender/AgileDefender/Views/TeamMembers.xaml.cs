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

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(37, -122), Distance.FromMiles(1)));
        }
    }
}
