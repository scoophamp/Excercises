using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excersise7
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Ssn { get; set; }
        public int Wage { get; set; }
        public string FullName
        {  // kapslar in en sorts metod i denna variablen
            get
            {
                return FirstName+ " " + LastName; // Detta är en set
            }
        }
        
        


        public Employee(string firstName, string lastName, long ssn, int wage)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Wage = wage;
        }
        public Employee(long ssn)
        {
            
        }
        public Employee()
        { }
        public void Reg()
        {
            
        }
        public void SkrivUtAnställd()
        {
            Console.WriteLine("" + FullName);
            Console.WriteLine("" + Ssn);
            Console.WriteLine("" + Wage);
        }
       
    }
}
