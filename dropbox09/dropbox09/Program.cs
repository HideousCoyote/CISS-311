/*Mark Chambers
CISS-311
Advanced Agile Development
02/08/2021*/

using System;
using System.Collections.Generic;
using System.Linq;


namespace dropbox09
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "dropbox09";
            //array of employees with name, hours, pay, department
            var employees = new[]
            {
                // Ran out of ideas for name These are from Gotham(Batman) TV Show
                new { Name = "Jim Gordon", Hours_Worked = 40, Pay_Rate = 30 , Department = "Electronics"},
                new { Name = "Barbara Keen", Hours_Worked = 40, Pay_Rate = 25, Department = "Main Office"},
                new { Name = "Oswald Cobblepot", Hours_Worked = 35, Pay_Rate = 15, Department = "Maintenance"},
                new { Name = "Edward Nygma", Hours_Worked = 28, Pay_Rate = 12, Department = "Electronics"},
                new { Name = "Bruce Wayne", Hours_Worked = 22, Pay_Rate = 44, Department = "Main Office"}
            };
            // LINQ statement to group employees by department
            var employeeQuery = from employee in employees
                                       group employee by employee.Department;
                                
            foreach (var eGroup in employeeQuery)
            {
                // added color to the key to break up the look
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(eGroup.Key);
                // Reset the color for the eGroups
                Console.ResetColor();
                foreach  (var e in eGroup)
                {
                    Console.WriteLine($"Name: {e.Name} Hours Worked: {e.Hours_Worked} Pay Rate:  {e.Pay_Rate} ");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
            
        }
    }
}
