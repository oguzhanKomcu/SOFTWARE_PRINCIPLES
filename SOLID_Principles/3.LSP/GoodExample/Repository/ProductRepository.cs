using SOLID_Principles._3.LSP.GoodExample.Abstract;
using SOLID_Principles._3.LSP.GoodExample.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExample.Repository
{
    public class ProductRepository : BaseRepository, IProduct
    {
        //I only applied my methods that are related to the product entity in my repository.
        //Thus, I complied with our principle.
        //Because my methods that are not related to it are not available in this class.

        public override string Create()
        {
            return "Create my product.";
        }

        public override string Delete()
        {
            return "Delete my existing product.";

        }

        public override string GETAll()
        {
            return "List all my products.";

        }


        //Here I implemented my skill working with my product class.

        public string GetPrice()
        {
            return "Bring my items priced between $110 and $200.";
        }

        public override string Update()
        {
            return "Update my product's features.";
        }
    }
}
