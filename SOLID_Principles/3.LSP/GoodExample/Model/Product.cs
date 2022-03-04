using SOLID_Principles._3.LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExample.Model
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public int Category_Id { get; set; }
        public decimal UnıtInStock { get; set; }

        public int Price { get; set; }





    }
}
