using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Neudesic.Tastings.Configuration;
using Neudesic.Tastings.Helpers;
using Neudesic.Tastings.Models;
using Neudesic.Tastings.Services;
using Xamarin;
using Xamarin.Forms;

namespace Neudesic.Tastings.ViewModels
{
    public class TastingItemDetailsViewModel : BaseViewModel
    {
        private readonly ITastingService _tastingService;
        private readonly INavigation _navigation;

        public TastingItem TastingItem { get; private set; }

        public TastingItemDetailsViewModel(INavigation navigation, TastingItem tastingItem)
        {
            _tastingService = ServiceLocator.TastingService;

            _navigation = navigation;
            TastingItem = tastingItem;
        }

        private int _voteScore;
        public int VoteScore
        {
            get { return _voteScore; }
            set { _voteScore = value; OnPropertyChanged("VoteScore"); }
        }

        private Command _decrementVoteCommand;
        public ICommand DecrementVoteCommand
        {
            get { return _decrementVoteCommand ?? (_decrementVoteCommand = new Command(DecrementVote)); }
        }

        private Command _incrementVoteCommand;
        public ICommand IncrementVoteCommand
        {
            get { return _incrementVoteCommand ?? (_incrementVoteCommand = new Command(IncrementVote)); }
        }

        private Command _voteCommand;
        public ICommand VoteCommand
        {
            get { return _voteCommand ?? (_voteCommand = new Command(async () => await ExecuteVoteCommand())); }
        }

        private void DecrementVote()
        {
            if (VoteScore > 0)
                VoteScore--;
        }

        private void IncrementVote()
        {
            if (VoteScore < 100)
                VoteScore++;
        }

        private async Task ExecuteVoteCommand()
        {
            var success = false;

            if (IsBusy)
                return;

            IsBusy = true;

            Insights.Track(AppConstants.ExecuteVoteCommand);

            try
            {
                if (Settings.UserId == 0)
                    await GetUser();

                if (Settings.UserId != 0)
                {
                    Insights.Track(AppConstants.SubmitVote);

                    success = await _tastingService.SubmitVote(
                        TastingItem.TastingEventId,
                        TastingItem.Id,
                        Settings.UserId,
                        _voteScore);
                }
            }
            catch (Exception ex)
            {
                // Log error in Xamarin.Insights
                Insights.Report(ex, new Dictionary<string, string>
                {
                    { "TastingId", TastingItem.TastingEventId.ToString() },
                    { "TastingItemId", TastingItem.Id.ToString() },
                    { "UserId", Settings.UserId.ToString() },
                    { "Score", _voteScore.ToString() }
                });

                success = false;
            }
            finally
            {
                IsBusy = false;
            }

            MessagingCenter.Send(this, success ? "SubmitVoteSucceeded" : "SubmitVoteFailed");
        }

        private async Task GetUser()
        {
            try
            {
                Insights.Track(AppConstants.GetUser);

                var user = await _tastingService.GetUser(TastingItem.TastingEventId, Settings.Username);
                Settings.UserId = user.Id;

            }
            catch (Exception ex)
            {
                // Log error in Xamarin.Insights
                Insights.Report(ex, new Dictionary<string, string>
                {
                    { "TastingId", TastingItem.TastingEventId.ToString() },
                    { "Username", Settings.Username },
                    { "UserId", Settings.UserId.ToString() }
                });
            }
        }
    }
}
