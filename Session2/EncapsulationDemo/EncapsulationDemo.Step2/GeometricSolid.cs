using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step2
{
    class GeometricSolid
    {
        
        public GeometricSolid(string solidType, double sideLength)
        {
            this.solidType = solidType;
            this.SideLength = sideLength;
        }

        private string solidType;

        public double SideLength { get; private set; }

        public double Volume { get; private set; }
        public double AreaOfFace { get; private set; }
        public double SurfaceArea { get; private set; }

        public void Calculate()
        {
            if (solidType == "1")
            {
                AreaOfFace = Math.Sqrt(3) / 4 * SideLength * SideLength;
                SurfaceArea = 4 * AreaOfFace;
                Volume = Math.Sqrt(2) / 12 * SideLength * SideLength * SideLength;
            }
            else if (solidType == "2")
            {
                AreaOfFace = SideLength * SideLength;
                SurfaceArea = 6 * AreaOfFace;
                Volume = SideLength * SideLength * SideLength;
            }
            else if (solidType == "3")
            {
                AreaOfFace = Math.Sqrt(3) / 4 * SideLength * SideLength;
                SurfaceArea = 8 * AreaOfFace;
                Volume = Math.Sqrt(2) / 3 * SideLength * SideLength * SideLength;
            }
            else if (solidType == "4")
            {
                AreaOfFace = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * SideLength * SideLength / 4;
                SurfaceArea = 12 * AreaOfFace;
                Volume = (15 + 7 * Math.Sqrt(5)) / 4 * SideLength * SideLength * SideLength;
            }
            else
            {
                AreaOfFace = Math.Sqrt(3) / 4 * SideLength * SideLength;
                SurfaceArea = 20 * AreaOfFace;
                Volume = 5 * (3 + Math.Sqrt(5)) / 12 * SideLength * SideLength * SideLength;
            }
        }
        
    }
}
