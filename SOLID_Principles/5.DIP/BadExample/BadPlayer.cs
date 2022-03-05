using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.DIP.BadExample
{
    public class BadPlayer
    {



        //I am constantly calling my classes and using the elements of my class.
        //This is actually a situation we are used to until now or it is not a problem in small projects.
        //But consider that this is done all the time in large projects.
        //Things can get complicated when we create a new object in each class to use other classes.



        Music music = new Music();

        Video Video = new Video();

        public string GetPlayer()
        {
            return $" Video : {Video.FilePlay()}\n Music : {music.FilePlay()}  ";
        }





    }
}
