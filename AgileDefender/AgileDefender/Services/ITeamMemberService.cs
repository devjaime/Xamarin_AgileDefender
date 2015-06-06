using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgileDefender.Models;

namespace AgileDefender.Services
{
    public interface ITeamMemberService
    {
        ObservableCollection<TeamMemberModel> GetTestData();
    }
}
