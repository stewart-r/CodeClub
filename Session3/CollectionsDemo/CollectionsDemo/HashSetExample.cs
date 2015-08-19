using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class HashSetExample
    {
        /*  A hashset in analagous to a mathematical set - each element is unique and a set has no ordering
         *  
         *  Hashsets provide very fast membership tests and set operations such as unions, differences, intersections etc.
         *  They are useful if you need to perform lots of the operations mentioned above but perform poorly when looping over elements
         */

        public static void Demo()
        {

            HashSet<string> setOfStrings = new HashSet<string>(new string[] { "aa", "ab", "bc" });
            int noOfElements = setOfStrings.Count; //3

            //.Add() now returns a bool value to indicate if the addition was succesfull;
            bool bcAdded = setOfStrings.Add("bc");
            bool caAdded = setOfStrings.Add("ca");
            
            //we have access to some additional methods that change the list too, e.g.:
            setOfStrings.Add("bd"); //appends a single entry to the end of the list

            //Some useful HashSet<> methods:
            HashSet<string> set1 = new HashSet<string>(new string[] { "aa", "ab", "bc" });
            HashSet<string> set2 = new HashSet<string>(new string[] { "aa", "ab", "da" });
            HashSet<string> set3 = new HashSet<string>(new string[] { "aa", "ab" });

            set1.UnionWith(set2);                   // set1 = {"ab", "aa", "bc", "da"}
            bool isSubset = set3.IsSubsetOf(set1);  // true
            set1.IntersectWith(set3);               // set1 = {"ab", "aa"}

            Console.ReadLine();
        }
    }
}
