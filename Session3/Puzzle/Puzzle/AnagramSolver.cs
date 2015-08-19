using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public class AnagramSolver
    {
        List<string> words;

        //You can add other variables or collections here that might help....

        public AnagramSolver()
        {
            words = File.ReadAllLines("words.txt").Select(w=>w.ToLower().Trim()).ToList();

            // Maybe you can do some manipulation here or create one or more useful collections before you begin?


        }

        public IEnumerable<string> FindAnagrams(string input)
        {
            List<string> retVal;

            //////////////////////////////////////////////////////////////////////
            //replace this with your anagram solving code                       //
            //                                                                  //
            // hint: Consider that a string can be viewed as an array of char   //
            //       and think about nested collections                         //
                                                                                //
            if (input == "lemon")                                               //
            {                                                                   //
                retVal = new List<string> { "melon", "lemon" };                 //
            }                                                                   //
            else                                                                //
            {                                                                   //
                retVal = new List<string>();                                    //
            }                                                                   //
            //////////////////////////////////////////////////////////////////////

            return retVal;
        }
    }
}
