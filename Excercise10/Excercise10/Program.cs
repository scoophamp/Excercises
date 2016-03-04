using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData vehicledata = new VehicleData();
            Boat boat = new Boat("");
            Car car = new Car();

            var PrintVehicle = new VehicleData();
            PrintVehicle.PrintVehicleData(boat);
            
        }
    }
}
