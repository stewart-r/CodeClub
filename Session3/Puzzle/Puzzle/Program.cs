using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class Program
    {

        static void Main(string[] args)
        {
            var solver = new AnagramSolver();
            var userInput = "";

            while(userInput != "X")
            {
                Console.WriteLine("Please enter a word to check for anagrams:");
                userInput = Console.ReadLine();

                var anagrams = solver.FindAnagrams(userInput);

                if (userInput != "X")
                {
                    if (anagrams.Count() == 0)
                    {
                        Console.WriteLine("No anagrams found!");
                    }
                    else
                    {
                        Console.WriteLine("These anagrams found:");
                        foreach (var solution in anagrams)
                        {
                            Console.WriteLine(solution);
                        }
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
