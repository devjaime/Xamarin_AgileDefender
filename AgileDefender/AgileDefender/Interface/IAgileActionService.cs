using AgileDefender.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDefender.Interface
{
    public interface IAgileActionService
    {
        ObservableCollection<AgileAction> GetTestData();
    }
}
