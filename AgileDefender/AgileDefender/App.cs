using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileDefender.Setup;
using Xamarin.Forms;

using AgileDefender.Views;

namespace AgileDefender
{
    public partial class App : Application
    {
        public App()
        {
            //var task = Task.Run(async () =>
            //{
            //    Service = await ActionService.GetAll();
            //});
            //task.Wait();
            Bootstrap.Register();
            var signInPage = new SignInPage();
            MainPage = new NavigationPage(signInPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
