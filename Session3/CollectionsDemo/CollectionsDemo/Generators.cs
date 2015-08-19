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

        static IEnumerable<int> NumbersDivisibleBy3()
        {
            int val = 3;
            while (true)
            {
                yield return val;
                val += 3;
            }
        }

        public static void Demo()
        {
            var numbersDvisibleBy2Or3 = EvenNumberGenerator()
                .Union(NumbersDivisibleBy3());

            foreach (int i in numbersDvisibleBy2Or3)
            {
                Console.WriteLine(i);

                if (i > 1000)
                {
                    break;
                }
            }

            Console.ReadLine();
            
        }
    }
}
