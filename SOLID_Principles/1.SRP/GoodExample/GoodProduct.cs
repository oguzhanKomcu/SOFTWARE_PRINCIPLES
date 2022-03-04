using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._1.SRP.GoodExample
{
    public class GoodProduct
    {
        //I created my class as it should be. My class no longer has any function other than its purpose. I only have members.

        public string Product_Name { get; set; }
        public string Product_Price { get; set; }
        public string UnitInStock { get; set; }
        public string Quantity { get; set; }




    }
}
