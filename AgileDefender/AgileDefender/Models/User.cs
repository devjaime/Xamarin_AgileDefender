using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileDefender.Models
{
    // TODO move this class to shared library from service layer
    public class User : BaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
