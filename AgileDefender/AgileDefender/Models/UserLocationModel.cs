using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDefender.Models
{
    public class UserLocationModel : BaseModel
    {
        public string AddressName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
