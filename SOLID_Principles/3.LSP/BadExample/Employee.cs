using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExample
{
    public class Employee : BadBaseEntity
    {


       public DateTime BirthDate { get; set; }  
        public string Address { get; set; }

        public decimal Salary { get; set; }


        //Since the Employe does not have a price, we cannot do a specific filtering and use this method here.

        public override string GetPrice()
        {
           
            throw new NotImplementedException();
        }

        public override string GetSalary()
        {
            return " Bring my employees with salary over $3000.";
        }
    }
}
