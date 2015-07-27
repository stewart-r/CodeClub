using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step4
{
    class Dodecahedron:GeometricSolid
    {
        public Dodecahedron(double sideLength):base(sideLength)
        {

        }

        public override void Calculate()
        {
            AreaOfFace = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * SideLength * SideLength / 4;
            SurfaceArea = 12 * AreaOfFace;
            Volume = (15 + 7 * Math.Sqrt(5)) / 4 * SideLength * SideLength * SideLength;
        }
    }
}
