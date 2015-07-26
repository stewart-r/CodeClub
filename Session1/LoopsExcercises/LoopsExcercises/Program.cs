using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 1:

            long result = 1;

            for (int i = 1; i < 15; i = i + 1)
            {
                result = result * i;
            }

            Console.WriteLine(result);

            //Excerise 2:
            string inputVal = "";

            while (inputVal != "stop")
            {
                inputVal = Console.ReadLine();
                if (inputVal == "stop")
                {
                    Console.WriteLine("Stopping...");
                }
                else
                {
                    Console.WriteLine(inputVal);
                }
            }
        }
    }
}
