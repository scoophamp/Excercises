using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excersise7;
using Exercise7;

namespace Excersise9
{
    class Program
    {
        static Registery Reg = new Registery(); // konstruktor
        static Logger loggen = new Logger(); // konstruktor
        Employee NyAnställd = new Employee(); //konstruktor

        static void Meny()
        {
            
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Remove employee");
            Console.WriteLine("3. Print entire registry");
            Console.WriteLine("4. Exit");

        } //Metod för en samling av val
        static void LäggTillAnställd()
        {
            Console.WriteLine("Lägg till anställd");
            Console.WriteLine("------------------");

            Console.WriteLine("Ange förnamn: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Ange efternamn: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Ange SSN: ");
            long ssn= long.Parse(Console.ReadLine());

            Console.WriteLine("Ange timlön: ");
            int wage = int.Parse(Console.ReadLine());

            Employee NyAnställd = new Employee(firstname, lastname,ssn,wage); //konstruktor
            Reg.LäggTill(NyAnställd);

            loggen.Log("");

            Console.ReadKey();
            
        } //Metod för att lägga till anställd
        static void TabortAnställd()
        {
            Console.WriteLine("Radera anställd genom SSN, vänligen ange SSN-nr: ");
            long ssn = int.Parse(Console.ReadLine());

            Employee Erase = new Employee(ssn); //konstruktor
            Reg.removeemploy(ssn);
        } //Metod för att ta bort
        static void Main(string[] args)
        {
            

            string val = "";
            while (val != "Q")
            {
                Console.Clear();
                Meny();
                var selektion = Console.ReadLine();
                Console.Clear();
            {

                switch (selektion)
            {
                case "1":
                    LäggTillAnställd();
                    break;
                case "2":
                            TabortAnställd();
                            break;
                        case "3":
                            Reg.SkrivUtLista();
                            Console.ReadKey();
                            break;
                        case "4":
                    
                    Console.WriteLine("Välkommen åter, tryck valfri tangent för att avsluta");
                    Console.ReadKey();
                    Environment.Exit(0);
                    
                    break;

                default:
                    break;
                }
                }
            }
        }
    }
}

