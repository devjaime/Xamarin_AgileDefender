using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDefender.Interface
{
    public interface IUserService
    {
        Task GetUser(string emailAddress);
    }
}
