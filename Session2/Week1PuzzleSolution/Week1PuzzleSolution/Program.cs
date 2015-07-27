using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1PuzzleSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 0;
            
            for (int i = 1; i < 1000000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    result = result + i;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
