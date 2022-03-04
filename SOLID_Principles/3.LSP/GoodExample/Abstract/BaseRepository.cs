using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExample.Abstract
{
    public abstract class BaseRepository
    {

        //Use it in common, I created my methods that I can give capabilities to my other classes.
        //In this way, I complied with LSP.
        //I will no longer have methods that are not capable in subclasses.

        public abstract string Create();
        public abstract string Update();
        public abstract string Delete();
        public abstract string GETAll();




    }
}
