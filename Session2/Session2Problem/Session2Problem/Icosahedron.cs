using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step4
{
    class Icosahedron : GeometricSolidTriangleBased
    {
        public Icosahedron(double sideLength):base(sideLength)
        {

        }
        public override void Calculate()
        {
            CalculateAreaOfFace();
            SurfaceArea = 20 * AreaOfFace;
            Volume = 5 * (3 + Math.Sqrt(5)) / 12 * SideLength * SideLength * SideLength;
        }
    }
}
