using SOLID_Principles._3.LSP.GoodExample.Abstract;
using SOLID_Principles._3.LSP.GoodExample.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.GoodExample.Repository
{
    public class EmployeeRepository : BaseRepository ,IEmployee
    {
        public override  string Create()
        {
            return "Create my employee.";
        }

        public override string Delete()
        {
            return "Delete my existing employee.";
        }

        public override string GETAll()
        {
            return "List all my employees.";
        }


        public string GetSalary()
        {
            return "Bring in my employees whose salary is between $2500 and $3000.";
        }

        public override string Update()
        {
            return "Update my employee's data";
        }
    }
}
