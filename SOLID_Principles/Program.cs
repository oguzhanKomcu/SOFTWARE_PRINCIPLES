using SOLID_Principles._2.OCP.BadExample;
using SOLID_Principles._2.OCP.GoodExample.Abstract;
using SOLID_Principles._2.OCP.GoodExample.Models;

using SOLID_Principles._5.DIP.GoodExample;
using SOLID_Principles._5.DIP.GoodExample.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class Program
    {


        static void Main(string[] args)
        {


            //Now here I am creating an object from my class and accessing its elements.
            //I am applying my method that I will use inside the constructor method.
            // So now I don't call my classes one by one, I call the class I need. I reach the result directly with the methods I apply.
            //I have reversed the addiction.
            var player = new Player(new Music());

            Console.WriteLine(player.GetPlayer());
            Console.ReadKey();














        }
    }
}
