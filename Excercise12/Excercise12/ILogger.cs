using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise12
{
    public interface ILogger
    {
        List<string> Logpost { get; set; }
        
        void Log(string message);
    }
    
}
