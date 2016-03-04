using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise12
{
    class LogApplikation
    {
        ILogger _logger; //Sparas som en vanlig variabel sk class variabel

       public LogApplikation(ILogger _Logger)
        {
            this._logger = _Logger;
        }
        public void Run()
        {
            while (true)
            {

                Console.WriteLine("1: Add message to the log");
            Console.WriteLine("2: Print log");
            Console.WriteLine("Choice: ");
            var val = Console.ReadLine();
                Console.Clear();


                switch (val)
            {
                case "1":
                    Console.WriteLine("Add message");
                    var message = Console.ReadLine();
                    _logger.Log(message);
                        
                    break;
                case "2":
                        foreach (var item in _logger.Logpost)
                        {
                            
                            Console.WriteLine(item);
                            
                        }
                    break;

                default:
                    break;
                }
            }
        }
    }
}
