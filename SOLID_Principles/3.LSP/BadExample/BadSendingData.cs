using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.LSP.BadExample
{
    public class BadSendingData
    {

        Employee employee;
        Product product;

        public void Sending_Data()
        {
            employee.Name = "Tom";
            employee.Last_Name = "HARDY";
            // employee.Price = "An employee has no price !!!!!!"; 


            //My Product entity would not have "Last_Name", but since I wrote it in an abstract class, it had to acquire those capabilities.
            //If there were more non-needed members in my Abstract class, it would have taken them as well.
            //When these are processed into the database, we may encounter bad results.
            //Our work could take longer and we could get errors.
            //These are the same in methods.
            //Abstract classes should not contain methods that are not valid in all classes.

            product.Name = "Camping_Stove";
            product.UnıtInStock = 50;
            product.Last_Name = "A product cannot have a last name.!!";
        




        }





    }
}
