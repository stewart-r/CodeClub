using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class LinqDemo
    {
        static List<int> list = new List<int> { 1, 2, 5, 4 };
        static int[] array = new int[] { 1, 5, 7, 8 };

        public static void Demo()
        {
            var combined = list
                .Concat(array);

            var combinedAndSortedInDescorder = list
                .Concat(array)
                .OrderBy(a => a);


        }

        public static void DemoCustomClass()
        {
            var names = employees
                .Select(e => e.Name);

            var employeeNumberInOrderOfSalary = employees
                .OrderByDescending(e => e.Salary)
                .Select(e => e.EmployeeNumber);
        }

        static List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Name = "Mike Saxby", EmployeeNumber = 56, Salary=10000
            },
            new Employee()
            {
                Name = "Ryan Jones", EmployeeNumber = 9, Salary = 20000
            },
            new Employee()
            {
                Name = "Pete Whitmarsh", EmployeeNumber = 25, Salary = double.PositiveInfinity
            }
        };

        class Employee
        {
            public string Name { get; set; }
            public int EmployeeNumber { get; set; }
            public double Salary { get; set; }
        }
    }
}
