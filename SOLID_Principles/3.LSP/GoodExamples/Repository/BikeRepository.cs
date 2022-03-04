
using SOLID_Principles._3.LSP.GoodExamples.Abstract;
using SOLID_Principles._3.LSP.GoodExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExamples.Repository
{
    public class BikeRepository : BaseRepository , IBike
    {
        //A class inherits from only one class. Thanks to interfaces, I can implement multiple inheritance.
        //Here, I wrote the class's private methods in the interface.
        //I also applied it here. Thus, he did not keep methods that did not belong to him in his own repository.
        public override string GetPrice()
        {
            return " Bring those over $300.";
        }

        public string Get_Squad_Length()
        {
            return "Bring the 50 cm staff.";
           
        }
    }
}
