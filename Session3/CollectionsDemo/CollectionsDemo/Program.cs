using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysExample.Demo();
            ListsExample.Demo();
            HashSetExample.Demo();
            QueuesAndStacks.Demo();

            LinqDemo.Demo();
            LinqDemo.DemoCustomClass();

            Generators.Demo();

            DictionaryExample.Demo();
        }
    }
}
