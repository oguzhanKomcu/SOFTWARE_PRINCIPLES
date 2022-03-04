using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExample.Abstract
{
    public class BaseEntity
    {
        //I created my properties that I can use in common that I can give abilities to my other classes.
        //In this way, I complied with LSP. Subclasses will no longer have non-capable members.
        public int ID { get; set; }

        DateTime _createdate = DateTime.Now;
        public DateTime CreateDate { get => _createdate; set => _createdate = value; }

        public DateTime UpdateDate { get; set; }

        public DateTime DeleteDate { get; set; }


    }
}
