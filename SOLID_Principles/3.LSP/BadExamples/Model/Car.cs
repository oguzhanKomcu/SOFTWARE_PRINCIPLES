using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExamples.Model
{
    public class Car
    {
        public int Id { get; set; } 
        public string Gear { get; set; }

        public string Fuel_type { get; set; }
        public  double Price { get; set; }  


    }
}
