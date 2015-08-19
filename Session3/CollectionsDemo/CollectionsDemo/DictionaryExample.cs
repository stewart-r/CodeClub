using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class DictionaryExample
    {
        /*  A Dictionary associates a 'Key' and a 'Value' - each key must be unique. 
         *  
         *  A dictionary provides very fast look-up. It's typically used when you have a unique 'index' for a set of objects.
         */

        public static void Demo()
        {

            Dictionary<string, double> employeeSalaries = new Dictionary<string, double>() //think of it as a map from employee to salary
            {
                { "Mike Saxby",100000 },
                { "Ryan Jones", 20000 },
                { "Pete Whitmarsh",double.PositiveInfinity }
            };

            //Now we can obtain an employee salary by 'indexing' into the dictionary with the key:
            double mikesSalary = employeeSalaries["Mike Saxby"];

            // we can also change the stored values:
            employeeSalaries["Mike Saxby"] += 1000;

            //or add new ones:
            employeeSalaries["Dan Akers"] = 50000;

        }

    }
}
