using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Generators
    {
        static IEnumerable<int> EvenNumberGenerator()
        {
            int val = 0;
            while (true)
            {
                yield return val;
                val += 2;                       //(we can  do val += 2 as shorthand for val = val + 2;)
            }
        }

        public static void Demo()
        {
            var evenNumbers = EvenNumberGenerator();


            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);

                if (i >= 1000)
                {
                    break;
                }
            }

            Console.ReadLine();
            
        }
    }
}
