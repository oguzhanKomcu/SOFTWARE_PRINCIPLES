using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.Model
{
    public class Bike
    {
        //Here I have created my entity which will correspond to my table in my database.

        public int Id { get; set; }
        public string Gear { get; set; }
        public string Rim_Size { get; set; }    
        public double Price { get; set; }
    }
}
