using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin;
using Xamarin.Forms;

using Neudesic.AgileDefender.Dtos;
using Neudesic.AgileDefender.Helpers;
using Neudesic.AgileDefender.Models;
using Neudesic.AgileDefender.Services;
//using Neudesic.AgileDefender.Views;

namespace Neudesic.AgileDefender.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        //private readonly ITastingService _tastingService;
        //private readonly INavigation _navigation;

        //public SignInViewModel(INavigation navigation)
        //{
        //    _navigation = navigation;
        //    _tastingService = ServiceLocator.TastingService;

        //    if (Settings.EventCode != null)
        //        _eventCode = Settings.EventCode;

        //    if (Settings.Username != null)
        //        _username = Settings.Username;

        //    if (Settings.UserEmail != null)
        //        _email = Settings.UserEmail;
        //}

        //private string _username;
        //public string Username
        //{
        //    get { return _username; }
        //    set { _username = value; OnPropertyChanged("Username"); }
        //}

        //private string _eventCode;
        //public string EventCode
        //{
        //    get { return _eventCode; }
        //    set { _eventCode = value; OnPropertyChanged("EventCode"); }
        //}

        //private string _email;
        //public string Email
        //{
        //    get { return _email; }
        //    set { _email = value; OnPropertyChanged("Email"); }
        //}

        //private Command _signInCommand;

        //public ICommand SignInCommand
        //{
        //    get { return _signInCommand ?? (_signInCommand = new Command(async () => await ExecuteSignInCommand())); }
        //}

        //private async Task ExecuteSignInCommand()
        //{
        //    if (IsBusy)
        //        return;

        //    IsBusy = true;
        //    try
        //    {
        //        // Call service to load the data for the tasting
        //        await _tastingService.LoadTastingEvent(_eventCode);

        //        // Save Username and Event Code if successful
        //        if (_tastingService.TastingEvent != null)
        //        {
        //            var user =
        //                await
        //                    _tastingService.RegisterUser(_tastingService.TastingEvent.Info.Id,
        //                        new TastingUser((new TastingUserDto
        //                        {
        //                            Email = _email,
        //                            Username = _username,
        //                            TastingId = _tastingService.TastingEvent.Info.Id
        //                        })));
                   
        //            Settings.Username = user.Username;
        //            Settings.EventCode = _eventCode;
        //            Settings.UserEmail = user.Email;

        //            // Identify the device user
        //            var userInfo = new Dictionary<string, string>
        //            {
        //                {"EventCode", _eventCode},
        //                {"Email", user.Email}
        //            };
        //            Insights.Identify(_username, userInfo);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Insights.Report(ex, Insights.Severity.Error);

        //        // Send message to inform user that Sign In failed
        //        //MessagingCenter.Send(this, "SignInFailed");

        //        //return;
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }

        //    var eventPage = new EventPage();
        //    await _navigation.PushAsync(eventPage);
        //}

    }
}
