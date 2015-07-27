using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step4
{
    class Octahedron:GeometricSolid
    {
        public Octahedron(double sideLength):base(sideLength)
        {

        }

        public override void Calculate()
        {
            AreaOfFace = Math.Sqrt(3) / 4 * SideLength * SideLength;
            SurfaceArea = 8 * AreaOfFace;
            Volume = Math.Sqrt(2) / 3 * SideLength * SideLength * SideLength;
        }
    }
}
