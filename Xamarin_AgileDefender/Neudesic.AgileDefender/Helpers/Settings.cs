// Helpers/Settings.cs
using Refractored.Xam.Settings;
using Refractored.Xam.Settings.Abstractions;

namespace Neudesic.Tastings.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string EventCodeKey = "eventCode";
        private const string UsernameKey = "username";
        private const string UserIdKey = "userId";
        private const string UserEmailKey = "userEmail";
        private static readonly string SettingsDefault = null;
        private const int UserIdDefault = 0;

        #endregion

        public static string EventCode
        {
            get { return AppSettings.GetValueOrDefault(EventCodeKey, SettingsDefault); }
            set { AppSettings.AddOrUpdateValue(EventCodeKey, value); }
        }

        public static string Username
        {
            get { return AppSettings.GetValueOrDefault(UsernameKey, SettingsDefault); }
            set { AppSettings.AddOrUpdateValue(UsernameKey, value); }
        }

        public static int UserId
        {
            get { return AppSettings.GetValueOrDefault(UserIdKey, UserIdDefault); }
            set { AppSettings.AddOrUpdateValue(UserIdKey, value); }
        }

        public static string UserEmail
        {
            get { return AppSettings.GetValueOrDefault(UserEmailKey, SettingsDefault); }
            set { AppSettings.AddOrUpdateValue(UserEmailKey, value); }
        }
    }
}