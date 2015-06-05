using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgileDefender.Models;

namespace AgileDefender.Services
{
    public interface IUserService
    {
        Task GetUser(string emailAddress);
        User User { get; }
    }
}
