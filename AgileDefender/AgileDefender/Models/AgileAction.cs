using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgileDefender.Helpers;

namespace AgileDefender.Models
{
    public class AgileAction : BaseModel
    {
        public AgileAction(PageResourceName pageResourceName, string title, string image)
        {
            PageResourceName = pageResourceName;
            Title = title;
            Image = image;
        }

        public PageResourceName PageResourceName { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
