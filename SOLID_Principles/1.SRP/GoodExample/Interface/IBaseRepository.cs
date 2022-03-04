using SOLID_Principles._1.SRP.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._1.SRP.GoodExample.Interface
{
    public interface IBaseRepository
    {

        string Create(BadProduct product);


        string GetAll();



    }
}
