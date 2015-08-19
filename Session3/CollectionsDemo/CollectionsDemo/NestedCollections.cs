using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class NestedCollections
    {
        /*  A Collection is a Colection of T where T is the data type (for example a collection of strings, or a collection of integers, etc.

            It is often a powerful problem-solving tool to combine collections
         */

        public static void Demo()
        {
            //We can use this Dictionary of string to List of Competency to store lists of employees competencies: 
            Dictionary<string, List<Competency>> employeeCompetencies = new Dictionary<string, List<Competency>>();
            employeeCompetencies["MikeSaxby"] = new List<Competency>() { Competency.Ppc, Competency.Presenting };
            employeeCompetencies["RyanJones"] = new List<Competency>() { Competency.Ppc, Competency.Presenting, Competency.Management };

            //We can, of course, access the list of competencies like any other list:
            employeeCompetencies["MikeSaxby"].Add(Competency.CSharpProgramming);
        }


        enum Competency
        {
            CSharpProgramming,
            Ppc,
            Management,
            Presenting,
            Seo,
            DataAnalysis
        }
    }
}
