using EncapsulationDemo.Step2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            while (command != "X")
            {
                command = GetUserCommand();
                if (command != "X")
                {
                    double sideLength = GetSideLength();

                    GeometricSolid solid = new GeometricSolid(command, sideLength);
                    solid.Calculate();

                    Console.WriteLine("Surface Area: " + solid.SurfaceArea);
                    Console.WriteLine("Volume: " + solid.Volume);
                    Console.ReadLine();
                }
            }
        }

        private static double GetSideLength()
        {
            string sideLengthCommand = "";
            double sideLength;
            while (!double.TryParse(sideLengthCommand, out sideLength))
            {
                Console.WriteLine("Please enter the edge length:");
                sideLengthCommand = Console.ReadLine();
            }

            return sideLength;
        }

        private static string GetUserCommand()
        {
            string command = "";
            string[] validCommands = new string[] { "1", "2", "3", "4", "5", "X" };
            while (!validCommands.Contains(command))
            {
                Console.WriteLine("1. Tetrahedron");
                Console.WriteLine("2. Cube");
                Console.WriteLine("3. Octahedron");
                Console.WriteLine("4. Dodecahedron");
                Console.WriteLine("5. Isocahedron");
                Console.WriteLine("Please choose a type of solid above (or enter X to eXit):");
                command = Console.ReadLine();
            }

            return command;
        }
    }
}
