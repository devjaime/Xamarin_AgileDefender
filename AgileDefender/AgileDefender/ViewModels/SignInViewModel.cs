using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin;
using Xamarin.Forms;
using AgileDefender.Services;
using AgileDefender.Views;

namespace AgileDefender.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        private UserService userService;
        private readonly INavigation _navigation;
        private string userName;
        private string userPassword;

        public SignInViewModel(INavigation navigation)
        {
            userService = new UserService();
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
