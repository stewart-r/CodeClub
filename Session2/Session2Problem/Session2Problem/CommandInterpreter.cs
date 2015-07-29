using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Problem
{
    static class CommandInterpreter
    {
        public static GeometricSolid GeometricObjectFromCommand(string command, double sideLength)
        {
            GeometricSolid solid;
            if (command == "1")
            {
                solid = new Tetrahedron(sideLength);
            }
            else if (command == "2")
            {
                solid = new Cube(sideLength);
            }
            else if (command == "3")
            {
                solid = new Octahedron(sideLength);
            }
            else if (command == "4")
            {
                solid = new Dodecahedron(sideLength);
            }
            else
            {
                solid = new Icosahedron(sideLength);
            }

            return solid;
        }

        public static double GetSideLength()
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

        public static string GetUserCommand()
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
