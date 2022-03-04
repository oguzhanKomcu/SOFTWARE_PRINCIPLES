using SOLID_Principles._2.OCP.GoodExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2.OCP.BadExample
{
    public class BadShape
    {

        //Our method is working now and may look good.
        //While we should be open to development and closed to change, we are constantly changing our code.
        //We are constantly making additions. We have to constantly change it on demand.
        //This will cause problems when our project gets bigger.

        public double Perimeter_Calculation(double edge1, double edge2, double edge3)
        {

            double Triangle_Perimeter = edge1 + edge2 + edge3;
            
            return Triangle_Perimeter;


        }

        //When I wanted to use the method I used for the first Triangle now for my rectangle shape, I had to change its parameters.
        //When I do this constantly, both my work gets longer and my methods can get mixed up.

        public double Perimeter_Calculation(double edge1, double edge2)
        {

            double RectanglePerimeter = edge1*2 + edge2*2;

            return RectanglePerimeter;


        }



        //Now, when I wanted to use it in my flat, I had to change it again.
        //These can lead to more troublesome situations in large large projects . Therefore, it will be better for us to comply with OPC.

        public double Perimeter_Calculation(Object entity)
        {
            double Perimeter = 0;
            if (entity is Triangle)
            {
              Triangle triangle = (Triangle)entity; 
              Perimeter = triangle.Edge1+ triangle.Edge2;

            }
            else if (entity is Circle)
            {
                Circle circle = (Circle)entity;
                Perimeter = circle.Edge_R * 2 * Math.PI;
            }
            else if(entity is Rectangle)         
            {
                Rectangle rectangle = (Rectangle)entity;
                Perimeter = rectangle.Edge1*2+ rectangle.Edge2*2;

            }

            return Perimeter;
           
        }

    }
}
