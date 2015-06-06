using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDefender.Models
{
    public class TeamMemberModel : BaseModel
    {
        public TeamMemberModel(User User, UserLocationModel UserLocation)
        {
            this.User = User;
            this.UserLocation = UserLocation;
        }

        public User User { get; set; }
        public UserLocationModel UserLocation { get; set; }
    }
}
