using SOLID_Principles._2.OCP.BadExample;
using SOLID_Principles._2.OCP.GoodExample.Abstract;
using SOLID_Principles._2.OCP.GoodExample.Models;
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


            Triangle triangle = new Triangle();
            triangle.Edge1 = 40;
            triangle.Edge2 = 50;
            triangle.Edge3 = 75.80;

            BadShape badShape = new BadShape();

           double total = badShape.Perimeter_Calculation(triangle);

            Console.WriteLine($"{total}");
            Console.ReadKey();















        }
    }
}
