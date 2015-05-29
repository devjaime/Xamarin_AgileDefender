using AgileDefender.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin;
using Xamarin.Forms;

namespace AgileDefender.ViewModels
{
    public class SignInViewModel : INotifyPropertyChanged
    {
        private string userName;
        private string userPassword;

        public SignInViewModel()
        {
            try
            {
                this.SignInCommand = new Command((doWork) =>
                {
                    var actionListPage = new ActionListPage
                    {
                        //BindingContext = new ActionViewModel(action)
                    };

                    App.Current.MainPage.Navigation.PushAsync(actionListPage);
                });
            }
            catch (Exception ex)
            {
                Insights.Report(ex, Insights.Severity.Critical);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SignInCommand { get; protected set; }

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

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
