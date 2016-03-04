using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise10
{
    public abstract class Vehicle
    {
        public string model { get; set; }
        public string vehicle { get; set; }


        public Vehicle(string model)
        {
            this.model = model;
        }
        public virtual string DescribeVehicle() // lämnar info till overide
        {
            
             return "This vehicle is a " + vehicle;
            
        }
        
    }
}
