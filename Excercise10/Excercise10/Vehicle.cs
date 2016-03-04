using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise10
{
    public class Vehicle
    {
        public string model { get; set; }

        public Vehicle(string model)
        {
            this.model = model;
        }
        public string DescribeVehicle()
        {
            
             Console.WriteLine("This vehicle is a " + model);
            return "";
        }
    }
}
