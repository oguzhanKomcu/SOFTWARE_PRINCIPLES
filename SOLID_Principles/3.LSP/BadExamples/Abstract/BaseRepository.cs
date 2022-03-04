using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExamples.Abstract
{
    public abstract class BaseRepository
    {
        // I created my methods that I will override in subclasses.
        //But I wrote my method here, which cannot be used in the inheriting class because I do not follow my principle.

        public abstract string GetPrice();
        public abstract string GetFuelType();

       public abstract string Get_Squad_Length();

       
    }
}
