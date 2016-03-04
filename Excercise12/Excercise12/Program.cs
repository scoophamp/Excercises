using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise7;


namespace Excercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            // var logger = new Logger();
            var logger = new DateTimeLogger();
            var application = new LogApplikation(logger);
            application.Run();

           

        }

    }
}
