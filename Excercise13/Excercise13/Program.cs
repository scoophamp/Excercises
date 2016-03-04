using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("What year were you born: ");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Month: ");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Day: ");
            var day = int.Parse(Console.ReadLine());


            DateTime Birth = new DateTime(year, month, day);
            var age = DateTime.Now.Year - year;
            if (Birth.DayOfYear <= DateTime.Now.DayOfYear)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine(age - 1);
            }
            
            
            DateTime mynext = Birth.AddYears(100);

            DateTime today = DateTime.Today;

            TimeSpan newwws = today - Birth;
            
            



            Console.WriteLine("Hello " + name + ", you are " + age + " years old and you will turn" + newwws);
            Console.WriteLine("Your 100th birtday will be " + mynext);
            Console.ReadKey();


            
            


            
            
        }
    }
}
