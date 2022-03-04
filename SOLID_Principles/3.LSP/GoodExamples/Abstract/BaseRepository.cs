using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExamples.Abstract
{
    public abstract class BaseRepository
    {
        //I created my general method that I will use in my abstract class.

        public abstract string GetPrice();

    }
}
