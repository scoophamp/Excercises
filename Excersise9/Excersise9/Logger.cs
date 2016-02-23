using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise7
{
    class Logger
    {
        public List<string> Logpost { get;private set; }

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
