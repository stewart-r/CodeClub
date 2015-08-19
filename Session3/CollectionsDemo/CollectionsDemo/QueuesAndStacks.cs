using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class QueuesAndStacks
    {
        /*  Queues and Stacks offer little performance improvements over Lists but have a 'nice' interface when we need to store 
         *  objects in a First In First Out(FIFO) or Last In First Oout(LIFO) basis respectively
         *  
         *  If you have a need for such an interface using these collections rather than shoehorning a list makes your code easier to read and write.
         *
         */

        public static void Demo()
        {

            //Stacks:
            Stack<string> stackOfStrings = new Stack<string>(new string[] { "aa", "ab", "bc" });

            //'pop' an element off the top:
            string s1 = stackOfStrings.Pop();   // now s1 == "bc" and stackOfStrings == {"aa", "ab"}

            //or 'push' a new element onto the stack:
            stackOfStrings.Push("ca");          // now stackOfStrings =  { "aa", "ab", "ca" }


            //Queues:
            Queue<string> queueOfStrings = new Queue<string>(new string[] { "aa", "ab", "bc" });

            //for queues we use .Enqueue() and Dequeue():
            s1 = queueOfStrings.Dequeue();  //s1 == "aa" and stackOfStrings == {"ab", "bc"}
            queueOfStrings.Enqueue("ca");   //stackOfStrings == {"ab", "bc", "ca"}        ("ab" would be the next one out if we dequeued again)

            Console.ReadLine();
        }
    }
}
