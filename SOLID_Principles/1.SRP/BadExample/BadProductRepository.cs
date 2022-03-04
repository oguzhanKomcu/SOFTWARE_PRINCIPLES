using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._1.SRP.BadExample
{
    public class BadProductRepository
    {
        //While adding my product, I also asked it to bring all the products.
        //This is wrong.The task of a method should only be related to its own work.
        //This may cause problems in making changes later when my codes grow and prolong my work.
        public void Create()
        {
            string create = "A new product has been created.";
            string list = "GetAll()";
        }




    }
}
