using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step4
{
    abstract class GeometricSolid
    {

        public GeometricSolid(double sideLength)
        {
            this.SideLength = sideLength;
        }

        private string solidType;

        public double SideLength { get; private set; }

        public double Volume { get; protected set; }
        public double AreaOfFace { get; protected set; }
        public double SurfaceArea { get; protected set; }

        public abstract void Calculate();

    }
}
