using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

using Toasts.Forms.Plugin.Abstractions;

using AgileDefender.Services;

namespace AgileDefender.Setup
{
    public static class Bootstrap
    {
        public static IContainer Container { get; set; }

        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(new UserService()).As<IUserService>();
            builder.RegisterInstance(new AgileActionService()).As<IAgileActionService>();

            //builder.RegisterType<IToastNotificator>();

            Container = builder.Build();
        }
    }
}
