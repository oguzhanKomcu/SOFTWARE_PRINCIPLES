using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExample
{
    public  class Product : BadBaseEntity
    {

        public int Category_Id  { get; set; }
        public decimal UnıtInStock { get; set; }

        public override string GetPrice()
        {
            return "Bring the ones that cost between $20 and $50.";
        }

        //Since my products do not have a salary, this method is unnecessary.This is a wrong practice.

        public override string GetSalary()
        {
            throw new NotImplementedException();
        }
    }
}
