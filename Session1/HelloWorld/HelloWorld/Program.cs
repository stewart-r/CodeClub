using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            if (name == "Subina")
            {
                Console.WriteLine("Bonjour " + name);
            }
            else
            {
                if (name == "Ben")
                {
                    Console.WriteLine("Guten tag " + name);
                }
                else
                {
                    Console.WriteLine("Hello " + name);
                }
            }

            Console.ReadLine();
        }
    }
}
