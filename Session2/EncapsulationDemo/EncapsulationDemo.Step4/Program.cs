using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo.Step4
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while (command != "X")
            {
                command = CommandInterpreter.GetUserCommand();
                if (command != "X")
                {
                    double sideLength = CommandInterpreter.GetSideLength();

                    GeometricSolid solid = CommandInterpreter.GeometricObjectFromCommand(command, sideLength);
                    solid.Calculate();

                    Console.WriteLine("Surface Area: " + solid.SurfaceArea);
                    Console.WriteLine("Volume: " + solid.Volume);
                    Console.ReadLine();
                }
            }
        }
    }
}
