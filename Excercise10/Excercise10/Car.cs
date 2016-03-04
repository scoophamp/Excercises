using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise10
{
    class Car : Vehicle
    {
      public Car():base("bil")
        {
            
        }
        bool engineIsRunning = false;

        public void StartEngine()
        {
            engineIsRunning = true;
        }
        public void StopEngine()
        {
            engineIsRunning = false;
        }
    }
}
