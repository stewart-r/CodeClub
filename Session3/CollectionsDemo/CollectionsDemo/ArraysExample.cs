using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class ArraysExample
    {
        /*  An array is the simplest type of collection

            Arrays are efficient with memory use and provide good indexing and iteration over the array but
            they are perform poorly when adding or removing elements, sorting, etc.
        */

        public static void Demo()
        {
            
            //Arrays store a collection of 'objects' in a single variable like this:
            int[] arrayOfintegers = new int[] { 1, 5, 7, 4, 5 };


            //We can loop over all elements like this:
            foreach (int i in arrayOfintegers)
            {
                Console.WriteLine(i);
            }

            //Access the (n-1)th element like this (The first element is array[0]).
            int j = arrayOfintegers[2];

            //And find properties of the array such as the length by doing array. For Example:
            int sizeOfArray = arrayOfintegers.Length;


            // strings can be converted to arrays of the char datatype:
            string s = "Stewart";
            char[] charArray = s.ToArray();
            Console.WriteLine(charArray);

            Console.ReadLine();
        }
    }
}
