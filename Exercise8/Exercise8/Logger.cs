using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Logger
    {
        public List<string> Logpost { get;private set; }

        public void Log(string message)
        {
            Logpost.Add(message);
        }
        
        public Logger()
        {
            Logpost = new List<string>();

            
        }
    }
}
