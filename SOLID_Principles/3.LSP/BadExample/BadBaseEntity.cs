using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExample
{
    public abstract class BadBaseEntity
    {

        //When creating our abstract classes, we must implement members and methods that are common to other classes.
        //Liskov's Substitution Principle asks us to:
        //It says that objects created from subclasses must exhibit the same behavior when they are replaced by objects of superclasses.
        //Well; Derived classes must use all the properties of the derived classes.
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Last_Name { get; set; }

        public decimal Price { get; set; }  

        DateTime _createdate = DateTime.Now;
        public DateTime CreateDate { get => _createdate; set => _createdate = value; }


        public abstract string GetPrice(); 
        public abstract string GetSalary();



    }
}
