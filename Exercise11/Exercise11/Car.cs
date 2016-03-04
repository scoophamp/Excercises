using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise10
{
    class Car : Vehicle
    {
        public bool EngineIsRunning { get; set; }

        public Car():base("Car") // Alltid när man ärver så måste man ha base i sina kontruktorer
        {
            
        }
      
        public void StartEngine()
        {
            EngineIsRunning = true;
            
        }
        public void StopEngine()
        {
           EngineIsRunning = false;
        }
        public override string DescribeVehicle() //override skriver över basklassen
        {
            var result = base.DescribeVehicle() + " The model is " + model;
            
            return result;
        }
    }
}
