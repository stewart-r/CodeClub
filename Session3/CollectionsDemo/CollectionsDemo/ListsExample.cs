using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class ListsExample
    {
        /*  A List provides more functionality than an array for only a very modest increase in memory usage.
         *  
         *  A list is much more performant for inserting and and removing than an array
         */

        public static void Demo()
        {

            //note the different syntax for a list
            List<string> listOfStrings = new List<string> { "aa", "ab", "bc" };


            //We can still loop over all & index into the collection as before:
            foreach (string s in listOfStrings)
            {
                Console.WriteLine(s);
            }
            string s1 = listOfStrings[1]; // (s1 = "ab")

            //we have access to some additional methods that change the list too, e.g.:
            listOfStrings.Add("bd"); //appends a single entry to the end of the list
            listOfStrings.Insert(2, "ac"); //inserts an element before the (n+1)th element            l
            listOfStrings.AddRange(new String[]{ "ca", "cb", "cc"}); //appends a range of new values

            int idx = listOfStrings.IndexOf("ab"); //returns the index of the first instance of the given value (int this instance idx = 1 because "ab" is second in the list)

            //NOTE: potential gotcha: Lists are 'reference' types so if we assign a list to a new variable it does not copy the list...
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = list1;
            list2.Add(4);                                   //Now you might exepct list1 to still be {1,2,3} but it is actually changed to {1,2,3,4}

            Console.ReadLine();
        }
    }
}
