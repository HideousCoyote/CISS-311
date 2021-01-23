// Mark Chambers
// CISS-311
// Advanced Agile Development
// 1/14/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace dropbox01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "dropbox01";
            // List to hold Employee
            List<Employee> allEmployees = new List<Employee>();

            // Add Two FULLTIME EMPLOYEES TO THE LIST
            allEmployees.Add(new FulltimeEmployee("Alice", "111-11-1234",   87999.00m));
            allEmployees.Add(new FulltimeEmployee("Bob",   "222-22-2345",   81234.00m));

            //Add Three PARTTIME EMPLOYEES TO THE LIST
            allEmployees.Add(new ParttimeEmployee("Chuck", "333-33-3456",   22.00m,   35.6m));
            allEmployees.Add(new ParttimeEmployee("Dan", "444-44-5678", 22.50m, 40m));
            allEmployees.Add(new ParttimeEmployee("Frank", "555-55-6789",   12.50m,   38.4m));

            //Print the data for each employee
            foreach(Employee emp in allEmployees)
            {
                Console.WriteLine(emp + "\n");
            }
            foreach(Employee emp in allEmployees)
            {
                if (emp is ParttimeEmployee)
                {
                    // DOwn cast emp to parttime employee
                    ParttimeEmployee pte = (ParttimeEmployee)emp;
                    pte.Wage = 1.10m * pte.Wage;
                    Console.WriteLine($"{pte.Name}'s new wage will be {pte.Wage:C}");
                }
            }

            Console.ReadKey();
        }
    }
}
