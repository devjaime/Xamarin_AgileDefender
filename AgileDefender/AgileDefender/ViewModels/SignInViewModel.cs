using System;
using System.Threading.Tasks;
using System.Windows.Input;
using AgileDefender.Interface;
using AgileDefender.Setup;
using AgileDefender.Views;
using Xamarin;
using Xamarin.Forms;

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

                // Call service to load the data for the tasting
                await userService.GetUser(userName);

                // Register user if successful

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
