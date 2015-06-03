using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin;

namespace AgileDefender.Services
{
    public class UserService
    {
        private string baseUrl = "https://tastings.neudesic.com/api";

        public User User { get; set; }

        public async Task GetUser(string emailAddress)
        {
            try
            {
                using (var handle = Insights.TrackTime("GetUser"))
                {
                    using (var client = new HttpClient())
                    {
                        var url = "https://tastings.neudesic.com/api/tastings/key/M134";//"http://localhost:57008/api/v1/user/getUserByEmail?emailAddress=aa";//string.Format("{0}/user/getUserByEmail/{1}", baseUrl, emailAddress);
                        var json = await client.GetStringAsync(url);
                        //var dto = JsonConvert.DeserializeObject<User>(json);
                        //User = new User
                        //{
                        //    Name = dto.Name,
                        //    EmailAddress = dto.EmailAddress
                        //};
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
