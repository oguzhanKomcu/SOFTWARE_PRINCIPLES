using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4.ISP.BadExamples.Interface
{
    public interface IBaseRepository
    {
        // I created my methods that I will override in subclasses.
        //But I wrote my method here, which cannot be used in the inheriting class because I do not follow my principle.
        //My interface was not a suitable interface.
        //It found my methods that I would not use in other classes.
        //Since all the elements in the interface are override in the implemented class, some of the methods I applied were written in vain.

        string GetPrice();
         string GetFuelType();

         string Get_Squad_Length();

       
    }
}
