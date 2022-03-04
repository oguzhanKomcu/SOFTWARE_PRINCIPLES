using SOLID_Principles._1.SRP.BadExample;
using SOLID_Principles._1.SRP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._1.SRP.GoodExample
{
    public class GoodProductRepository : IBaseRepository
    {

        //I inherited my methods from a base interface and applied them to my class, which contains the capabilities of my entity.
        public string Create(BadProduct product)
        {
            return "A new product has been created.";
        }

        public string GetAll()
        {

            return "The product table is listed.";
        }


    }
}
