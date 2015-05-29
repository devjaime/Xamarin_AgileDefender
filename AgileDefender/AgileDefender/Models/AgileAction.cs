using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileDefender.Models
{
    public class AgileAction
    {
        public AgileAction(string name, string image)
        {
            this.Name = name;
            this.Image = image;
        }

        public string Name { get; set; }
        public string Image { get; set; }
    }
}
