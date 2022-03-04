
using SOLID_Principles._2.OCP.GoodExample.Abstract;
using SOLID_Principles._2.OCP.GoodExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2.OCP.Repository
{
    public class RectangleRepository : BaseShape<Rectangle>
    {
        public override double Perimeter_Calculation(Rectangle entity)
        {
            return  entity.Edge1 * 2 + entity.Edge2 * 2;
        }
    }
}
