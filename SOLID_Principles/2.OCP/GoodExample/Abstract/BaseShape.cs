using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2.OCP.GoodExample.Abstract
{
    public abstract class BaseShape<T>
    {
        //I wrote my method on which I will make changes.
        //In this way, the parameters and function of my method will never change.
        //I will be able to develop this in my repositories at will.

        public abstract double Perimeter_Calculation(T entity);
       

    }
}
