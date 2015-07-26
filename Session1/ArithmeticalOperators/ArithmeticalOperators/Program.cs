using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            int a = 3 + 4;
            Console.WriteLine("3 + 4 = " + a);
            Console.ReadLine();

            //Multiplication
            int b = 3 * 4;
            Console.WriteLine("3 x 4 = " + b);
            Console.ReadLine();

            //Subtraction
            int c = 4 - 3;
            Console.WriteLine("4 - 3 = " + c);
            Console.ReadLine();

            //Division
            int d = 10 / 3;
            Console.WriteLine("10 ÷ 3 = " + d);
            Console.ReadLine();

            //Division Cont'd
            double e = 10 / 3;
            Console.WriteLine("10 ÷ 3 = " + e);
            Console.ReadLine();

            //Division Cont'd
            double f = 10.0 / 3;
            Console.WriteLine("10 ÷ 3 = " + f);
            Console.ReadLine();

            int remainder = 10 % 3;
            Console.WriteLine("The remainder when 10 is divided by 3 is: " + remainder);
            Console.ReadLine();

            //Math.
            double pi = Math.PI;
            Console.WriteLine("pi = " + pi);
            Console.ReadLine();

            double g = Math.Sqrt(64);
            Console.WriteLine("the square root of 64 is: " + g);
            Console.ReadLine();

            double h = Math.Pow(2,3);
            Console.WriteLine("2 to the power 3 is: " + h);
            Console.ReadLine(); 


            //assignment v equality
            h = 1;
            Console.WriteLine("h: " + h);
            Console.ReadLine();

            h = 1 + h * 2;
            Console.WriteLine("h: " + h);
            Console.ReadLine();

            bool i = h == h + 1;
            Console.WriteLine("i: " + i);
            Console.ReadLine();

        }
    }
}
