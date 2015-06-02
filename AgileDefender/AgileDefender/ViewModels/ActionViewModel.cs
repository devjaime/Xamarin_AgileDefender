using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Xamarin.Forms;

using AgileDefender.Models;
using AgileDefender.Services;

namespace AgileDefender.ViewModels
{
    public class ActionViewModel
    {
        public ActionViewModel()
        {
            // TODO Implement local and/or remote data service
            AgileActionItems = AgileActionService.GetTestData();
        }

        public ObservableCollection<AgileAction> AgileActionItems { get; private set; }
    }
}
