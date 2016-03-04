using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise10
{
    class Boat : Vehicle
    {
        public string colour { get; set; }

        public Boat (string colourBoat): base("boat")
        {
            this.colour = colourBoat;
        }
    }
}
