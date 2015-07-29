using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step4
{
    abstract class GeometricSolidTriangleBased : GeometricSolid
    {
        public GeometricSolidTriangleBased(double sideLength) : base(sideLength)
        {
        }

        protected virtual void CalculateAreaOfFace()
        {
            AreaOfFace = Math.Sqrt(3) / 4 * SideLength * SideLength;
        }
    }
}
