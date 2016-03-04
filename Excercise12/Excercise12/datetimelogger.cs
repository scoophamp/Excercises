using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise12
{
    class DateTimeLogger : ILogger
    {
        public List<string> Logpost { get; set; }


        public DateTimeLogger()
        {
            Logpost = new List<string>();
        }


        public void Log(string message)
        {
            Logpost.Add(message +  " "  + DateTime.Now);
            

        }
    }
}