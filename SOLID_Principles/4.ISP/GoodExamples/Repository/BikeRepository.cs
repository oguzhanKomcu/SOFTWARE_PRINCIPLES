

using SOLID_Principles._4.ISP.GoodExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4.ISP.GoodExamples.Repository
{
    public class BikeRepository : IBaseRepository , IBike
    {
        //A class inherits from only one class. Thanks to interfaces, I can implement multiple inheritance.
        //Here, I wrote the class's private methods in the interface.
        //I also applied it here. Thus, he did not keep methods that did not belong to him in his own repository.
        public string GetPrice()
        {
            return " Bring those over $300.";
        }

        public string Get_Squad_Length()
        {
            return "Bring the 50 cm staff.";
           
        }
    }
}
