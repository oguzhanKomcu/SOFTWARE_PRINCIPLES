using SOLID_Principles._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.DIP.GoodExample
{
    public class Player
    {






        //Here I created my field of type "IFormat" by doing some kind of encapsulation.
        //When this class is upgraded, I assign my "IFormat" type parameter to the variable in my field which is private in my constructor method.



        private IFormat _format;

        //In IFormat type, of course, it will be one of my classes that inherits from it.
        //Thus, I did not call a class again here.
        //I provide the dependency with my inteface, this way I don't have to call an object from a class again. I have to call n objects.

        public Player(IFormat format)
        {
            _format = format;

        }

        //Here I can access the method of the class I will use directly.
        public string GetPlayer()
        {
            return $"{_format.FilePlay()}";
        }




       









    }
}
