using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise7;
using Excersise7;

namespace Excersise9
{
    class Registery
    {
        public List<Employee> ListapåAnställda { get; set; }

        public Registery() 
        {
            ListapåAnställda = new List<Employee>();
        }
        public void LäggTill(Employee läggtill)
        {
            ListapåAnställda.Add(läggtill);
        }
        public void TaBort(Employee tabort)
        {
            ListapåAnställda.Remove(tabort);
            
        }
        public void SkrivUtLista()
        {
            foreach (Employee item in ListapåAnställda)
            {
                Console.WriteLine(item.FullName);
                Console.WriteLine(item.Ssn);
                
            }

         
        }
        public void removeemploy(long ssn)
        {
            for (int i = 0; i < ListapåAnställda.Count; i++)
            {
                if (ListapåAnställda[i].Ssn == ssn)
                {
                    ListapåAnställda.Remove(ListapåAnställda[i]);
                }
            }

        }
    }
   
    

    }
