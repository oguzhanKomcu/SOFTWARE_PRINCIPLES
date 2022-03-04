using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4.ISP.GoodExamples.Interface
{
    public interface IBaseRepository
    {
        //I created my general method that I will use in my interface.

        string GetPrice();

    }
}
