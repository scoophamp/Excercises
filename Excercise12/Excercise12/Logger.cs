using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise12;

namespace Exercise7
{
    class Logger : ILogger
    {
        public List<string> Logpost { get;set; }

        
        public Logger()
        {
            Logpost = new List<string>();
        }
       

        public void Log(string message)
        {
            Logpost.Add(message);
            Console.WriteLine("Du har lagt till en anställd!");

        }

       
    }
    
}
