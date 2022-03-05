using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.DIP.GoodExample.Interface
{
    public interface IFormat
    {
        //I am applying my method that I will use as a common in subclasses to my intefrace.
        //Thanks to my interface, I minimize my dependencies and ensure that the dependencies are installed with interfaces, not classes.

        string FilePlay();
    }
}
