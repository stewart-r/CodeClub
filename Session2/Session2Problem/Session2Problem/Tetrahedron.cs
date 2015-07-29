using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Problem
{
    class Tetrahedron : GeometricSolidTriangleBased
    {
        public Tetrahedron(double sideLength):base(sideLength)
        {

        }

        public override void Calculate()
        {
            CalculateAreaOfFace();
            SurfaceArea = 4 * AreaOfFace;
            Volume = Math.Sqrt(2) / 12 * SideLength * SideLength * SideLength;
        }
    }
}
