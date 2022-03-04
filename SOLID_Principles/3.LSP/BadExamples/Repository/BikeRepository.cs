using SOLID_Principles._3.LSP.BadExamples.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExamples.Repository
{
    public class BikeRepository : BaseRepository
    {

        //The bike does not run on any fuel.
        //So this method is not needed, but we had to have it in our base class.
        //We may know that this is an error.
        //But when our objects increase, we can forget.
        //Although we know, other developers interested in the project may not know.

        public override string GetFuelType()
        {
            throw new NotImplementedException("Bicycles don't have a fuel type.");
        }

        public override string GetPrice()
        {
            return "Bikes under $600.";
        }

        public override string Get_Squad_Length()
        {
            return "Bring the 50 cm staff.";
        }
    }


    
}
