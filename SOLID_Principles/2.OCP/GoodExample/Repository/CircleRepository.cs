

using SOLID_Principles._2.OCP.GoodExample.Abstract;
using SOLID_Principles._2.OCP.GoodExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2.OCP.Repository
{
    public class CircleRepository : BaseShape<Circle>
    {
        public override double Perimeter_Calculation(Circle entity)
        {
           return entity.Edge_R * 2 * Math.PI;
        }
    }
}
