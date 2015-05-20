using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using Neudesic.AgileDefender.Views;
using Xamarin;

namespace Neudesic.AgileDefender.Helpers
{
    public static class CreateToolBarItem
    {
        public static ToolbarItem CreateItem(string _imageName, NavigationPage _nav, string _page)
        {
            ToolbarItem newToolBaritem = null;

            newToolBaritem = new ToolbarItem()
            {
                Icon = _imageName,
                Command = CreateCommand(_nav, _page)
            };

            return newToolBaritem;
        }

        private static Command CreateCommand(NavigationPage _nav, string page)
        {
            Command newCommand = null;
            try
            {
                switch (page)
                {
                    case "SignInPage":
                        newCommand = new Command(o =>
                        {
                            Settings.EventCode = string.Empty;
                            Settings.UserEmail = string.Empty;
                            Settings.UserId = 0;
                            Settings.Username = string.Empty;
                            _nav.PushAsync(new SignInPage());
                        });
                        break;
                    case "EventPage":
                        newCommand = new Command(o =>
                        {
                            _nav.PushAsync(new EventPage());
                        });
                        break;
                    case "TastingItemListPage":
                        newCommand = new Command(o =>
                        {
                            _nav.PushAsync(new TastingItemListPage());
                        });
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                // Log error in Xamarin.Insights
                Insights.Report(ex, ReportSeverity.Error);
            }



            return newCommand;
        }
    }
}
