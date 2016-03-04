using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise10;


namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Boat boat = new Boat("");
            car.model = "Saab";
            boat.model = "Motorboat";
            boat.colour = "black";
            car.vehicle = "car";
            Console.WriteLine(car.DescribeVehicle());
            Console.WriteLine(boat.DescribeVehicle());
            car.StartEngine();
            if (car.EngineIsRunning)
            {
                Console.WriteLine("Engine is running");
            }
            else
            {
                Console.WriteLine("The engine is stopped");
            }
            
            Console.ReadKey();
        }
    }
}
