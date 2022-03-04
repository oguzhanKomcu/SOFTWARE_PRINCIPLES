using SOLID_Principles._3.LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExample.Model
{
    public  class Employee : BaseEntity
    {
       // "BaseEntity"ndan satın aldığım ama gereksiz mülkler için için sadece Çalışanlara ait mülklerimi oluşturdum.
        public string First_Name { get; set; }

        public string Last_Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public decimal Salary { get; set; }


    }
}
