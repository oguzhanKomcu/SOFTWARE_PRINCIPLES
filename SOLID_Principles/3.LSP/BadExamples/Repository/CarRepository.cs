using SOLID_Principles._3.LSP.BadExamples.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExamples.Repository
{
    public class CarRepository : BaseRepository
    {
        public override string GetFuelType()
        {
            return "Cars with fuel type gasoline.";
        }

        public override string GetPrice()
        {
            return "Cars under $30000.";
        }

        public override string Get_Squad_Length()
        {
            throw new NotImplementedException("Cars do not have a frame size.");
        }
    }
}
