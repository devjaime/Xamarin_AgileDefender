using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin;
using Xamarin.Forms;

using AgileDefender.Setup;
using AgileDefender.Views;
using AgileDefender.Services;
using Toasts.Forms.Plugin.Abstractions;

namespace AgileDefender.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        private readonly IUserService userService;
        private readonly INavigation _navigation;
        private string userName;
        private string userPassword;

        public SignInViewModel(INavigation navigation)
        {
            userService = ServiceLocator.GetService<IUserService>();
            _navigation = navigation;
        }

        private Command _signInCommand;

        public ICommand SignInCommand
        {
            get { return _signInCommand ?? (_signInCommand = new Command(async () => await ExecuteSignInCommand())); }
        }

        private async Task ExecuteSignInCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                // Get user from web service
                await userService.GetUser(userName);

                if (!userService.User.IsSuccess)
                {
                    // CJP TODO, see if IToastNotificator can be resolved with autofac
                    var notificator = DependencyService.Get<IToastNotificator>();
                    await notificator.Notify(ToastNotificationType.Warning, "Sign In Error", userService.User.ErrorMessage, TimeSpan.FromSeconds(3));
                }
            }
            catch (Exception ex)
            {
                // Log error in Xamarin.Insights
                Insights.Report(ex, Insights.Severity.Error);

                // Send message to inform user that Sign In failed
                MessagingCenter.Send(this, "SignInFailed");

                return;
            }
            finally
            {
                IsBusy = false;
            }

            var actionListPage = new ActionListPage
            {
                //BindingContext = new ActionViewModel(action)
            };

            await _navigation.PushAsync(actionListPage);
        }

        public string UserName
        {
            get { return userName; }
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }

        public string UserPassword
        {
            get { return userPassword; }
            set
            {
                if (userPassword != value)
                {
                    userPassword = value;
                    OnPropertyChanged("UserPassword");
                }
            }
        }
    }
}
