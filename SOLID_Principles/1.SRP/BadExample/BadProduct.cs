using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._1.SRP.BadExample
{
    public class BadProduct
    {



        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public string UnitInStock { get; set; }
        public string Quantity { get; set; }


        //Here, in my bad example, I added my methods in my class apart from my members.
        //While my class should only carry the members to which the entity's information will be transferred, I also added a method, a capability, to it.
        //Here I can get errors while accessing the database.
        //When my codes grow, I may not be able to find what comes from where. These can cause a lot of trouble and errors.

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
