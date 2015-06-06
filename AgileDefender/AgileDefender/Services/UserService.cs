using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin;

using AgileDefender.Models;
using AgileDefender.Helpers;

namespace AgileDefender.Services
{
    public class UserService : IUserService
    {
        private string baseUrl = "https://agiledefenderservices.azure-mobile.net/api";

        public User User { get; private set; }

        public async Task GetUser(string emailAddress)
        {
            try
            {
                using (var handle = Insights.TrackTime("GetUser"))
                {
                    if (string.IsNullOrEmpty(emailAddress))
                    {
                        User = new User
                        {
                            IsSuccess = false,
                            ErrorMessage = ValidationResources.SignInEmptyEmailAddressOrPassword
                        };
                    }
                    else
                    {
                        using (var client = new HttpClient())
                        {
                            var url = string.Format("{0}/v1/user/getUserByEmail/?emailAddress={1}", baseUrl, emailAddress);
                            var json = await client.GetStringAsync(url);
                            var dto = JsonConvert.DeserializeObject<User>(json);
                            User = new User
                            {
                                Id = dto.Id,
                                Name = dto.Name,
                                EmailAddress = dto.EmailAddress,
                                IsSuccess = dto.IsSuccess,
                                ErrorMessage = dto.ErrorMessage
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Insights.Report(ex, Insights.Severity.Error);
                throw;
            }
        }

    }
}
