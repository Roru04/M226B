using Events.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.EventArgs
{
    public class CarEventArgs : System.EventArgs
    {
        public double HP { get; set; }
        public Ferrari Ferari { get; set; }
    }
}
