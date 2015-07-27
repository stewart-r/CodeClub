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
        public double SingleFaceArea { get; private set; }
        public double SurfaceArea { get; private set; }

        public void Calculate()
        {
            if (solidType == "1")
            {
                SingleFaceArea = Math.Sqrt(3) / 4 * SideLength * SideLength;
                SurfaceArea = 4 * SingleFaceArea;
                Volume = Math.Sqrt(2) / 12 * SideLength * SideLength * SideLength;
            }
            else if (solidType == "2")
            {
                SingleFaceArea = SideLength * SideLength;
                SurfaceArea = 6 * SingleFaceArea;
                Volume = SideLength * SideLength * SideLength;
            }
            else if (solidType == "3")
            {
                SingleFaceArea = Math.Sqrt(3) / 4 * SideLength * SideLength;
                SurfaceArea = 8 * SingleFaceArea;
                Volume = Math.Sqrt(2) / 3 * SideLength * SideLength * SideLength;
            }
            else if (solidType == "4")
            {
                SingleFaceArea = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * SideLength * SideLength / 4;
                SurfaceArea = 12 * SingleFaceArea;
                Volume = (15 + 7 * Math.Sqrt(5)) / 4 * SideLength * SideLength * SideLength;
            }
            else
            {
                SingleFaceArea = Math.Sqrt(3) / 4 * SideLength * SideLength;
                SurfaceArea = 20 * SingleFaceArea;
                Volume = 5 * (3 + Math.Sqrt(5)) / 12 * SideLength * SideLength * SideLength;
            }
        }
        
    }
}
