using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Problem
{
    class Octahedron:GeometricSolidTriangleBased
    {
        public Octahedron(double sideLength):base(sideLength)
        {

        }

        public override void Calculate()
        {
            CalculateAreaOfFace();
            SurfaceArea = 8 * AreaOfFace;
            Volume = Math.Sqrt(2) / 3 * SideLength * SideLength * SideLength;
        }
    }
}
