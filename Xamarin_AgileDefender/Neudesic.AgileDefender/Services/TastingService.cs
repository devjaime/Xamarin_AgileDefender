using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Neudesic.Tastings.Configuration;
using Neudesic.Tastings.Dtos;
using Neudesic.Tastings.Models;
using Newtonsoft.Json;
using Xamarin;

namespace Neudesic.Tastings.Services
{
    public class TastingService : ITastingService
    {
        public TastingEvent TastingEvent { get; private set; }

        public async Task LoadTastingEvent(string tastingKey)
        {
            try
            {
                using (var handle = Insights.TrackTime(AppConstants.TimeToLoadTastingEvent))
                {
                    using (var client = new HttpClient())
                    {
                        var url = string.Format("{0}/tastings/key/{1}", AppConstants.TastingBaseSvcUrl, tastingKey);
                        var json = await client.GetStringAsync(url);
                        var dto = JsonConvert.DeserializeObject<TastingDto>(json);
                        TastingEvent = new TastingEvent(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                Insights.Report(ex, ReportSeverity.Error);
                throw;
            }
        }

        public async Task<TastingUser> GetUser(int tastingId, string username)
        {
            using (var handle = Insights.TrackTime(AppConstants.TimeToGetUser))
            {
                using (var client = new HttpClient())
                {
                    var url = string.Format("{0}/tastingusers/tasting/{1}/name/{2}", AppConstants.TastingBaseSvcUrl, tastingId, username);
                    var json = await client.GetStringAsync(url);

                    var dto = JsonConvert.DeserializeObject<TastingUserDto>(json);
                    return new TastingUser(dto);
                }
            }
        }

        public async Task<TastingUser> RegisterUser(int tastingId, TastingUser user)
        {
            using (var handle = Insights.TrackTime(AppConstants.TimeToRegisterUser))
            {
                using (var client = new HttpClient())
                {
                   var tastingUser = new TastingUserDto
                        {
                            TastingId = tastingId,
                            Email = user.Email,
                            Id = user.Id,
                            Username = user.Username
                        };

                        var contentToPost = new StringContent(JsonConvert.SerializeObject(tastingUser), Encoding.UTF8, "application/json");

                        var url = string.Format("{0}/TastingUsers/tasting/{1}/register/", AppConstants.TastingBaseSvcUrl, tastingId);

                        var response = await client.PostAsync(url, contentToPost);
                        var json = response.Content.ReadAsStringAsync().Result;
                        
                        var dto = JsonConvert.DeserializeObject<TastingUserDto>(json);
                        return new TastingUser(dto);
                }
            }
        }

        public async Task<bool> SubmitVote(int tastingId, int tastingItemId, int userId, int score)
        {
            using (var handle = Insights.TrackTime(AppConstants.TimeToSubmitVote))
            {
                using (var client = new HttpClient())
                {
                    var ballot = new TastingBallotDto
                    {
                        TastingId = tastingId,
                        TastingItemId = tastingItemId,
                        TastingMetricId = AppConstants.DefaultTestingMetricId,
                        TastingUserId = userId,
                        Score = score
                    };
                    var contentToPost = new StringContent(JsonConvert.SerializeObject(ballot), Encoding.UTF8, "application/json");

                    var url = string.Format("{0}/tastingballots/tasting/{1}", AppConstants.TastingBaseSvcUrl, tastingId);

                    var response = await client.PostAsync(url, contentToPost);

                    return response.IsSuccessStatusCode;
                }
            }
        }
    }
}
