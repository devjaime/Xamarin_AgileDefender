using Autofac;

namespace AgileDefender.Setup
{
    public static class ServiceLocator
    {
        public static T GetService<T>() where T : class
        {
            return Bootstrap.Container.Resolve<T>();
        }
    }
}
