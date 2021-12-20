using Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    public class Ferrari : Car
    {
        

        public string Model { get; set; }

        public Ferrari(string name, double megaTonnes) : base(megaTonnes)
        {
            Model = name;
        }
    }
}
