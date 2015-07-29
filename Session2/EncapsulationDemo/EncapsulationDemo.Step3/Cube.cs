﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step4
{
    class Cube:GeometricSolid
    {
        public Cube(double sideLength):base(sideLength)
        {

        }

        public override void Calculate()
        {
            AreaOfFace = SideLength * SideLength;
            SurfaceArea = 6 * AreaOfFace;
            Volume = SideLength * SideLength * SideLength;
        }
    }
}
