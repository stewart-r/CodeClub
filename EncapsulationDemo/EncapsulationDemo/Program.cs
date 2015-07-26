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
                string sideLengthCommand = "";
                double sideLength;
                while (!double.TryParse(sideLengthCommand, out sideLength))
                {
                    Console.WriteLine("Please enter the length of one side:");
                    sideLengthCommand = Console.ReadLine();
                }
                double a;
                double sa;
                double v;
                if (command == "1")
                {
                    a = Math.Sqrt(3) / 4 * sideLength * sideLength;
                    sa = 4 * a;
                    v = Math.Sqrt(2) / 12 * sideLength * sideLength * sideLength;
                }
                else if (command == "2")
                {
                    a = sideLength * sideLength;
                    sa = 6 * a;
                    v = sideLength * sideLength * sideLength;
                }
                else if (command == "3")
                {
                    a = Math.Sqrt(3) / 4 * sideLength * sideLength;
                    sa = 8 * a;
                    v = Math.Sqrt(2) / 3 * sideLength * sideLength * sideLength;
                }
                else if (command == "4")
                {
                    a = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * sideLength * sideLength / 4;
                    sa = 12 * a;
                    v = (15 + 7 * Math.Sqrt(5)) / 4 * sideLength * sideLength * sideLength;
                }
                else
                {
                    a = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * sideLength * sideLength / 4;
                    sa = 12 * a;
                    v = (15 + 7 * Math.Sqrt(5)) / 4 * sideLength * sideLength * sideLength;
                }

                Console.WriteLine("Surface Area: " + sa);
                Console.WriteLine("Volume: "+  v);
            }
        }

        
    }
}
