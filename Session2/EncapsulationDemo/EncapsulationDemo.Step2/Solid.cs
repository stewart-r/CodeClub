using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step2
{
    class Solid
    {
        private string solidType;

        public Solid(string solidType)
        {
            this.solidType = solidType;
        }

        public double SideLength { get; set; }

        public double CalculateVolume()
        {

        }

        public double CalculateAreaOfSingleFace()
        {
            //test
        }

        public double CalculateSurfaceArea()
        
    }
}
