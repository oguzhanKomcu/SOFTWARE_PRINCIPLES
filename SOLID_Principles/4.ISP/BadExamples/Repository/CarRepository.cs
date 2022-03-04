

using SOLID_Principles._4.ISP.BadExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4.ISP.BadExamples.Repository
{
    public class CarRepository : IBaseRepository
    {
        public string GetFuelType()
        {
            return "Cars with fuel type gasoline.";
        }

        public  string GetPrice()
        {
            return "Cars under $30000.";
        }

        public  string Get_Squad_Length()
        {
            throw new NotImplementedException("Cars do not have a frame size.");
        }
    }
}
