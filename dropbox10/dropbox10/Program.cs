/*Mark Chambers
CISS-311
Advanced Agile Development
02/08/2021*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program title
            Console.Title = "dropbox10";
        // array for employees
        var employees = new[]
            {
                // Names I used are from Gotham(Batman) short on Ideas
                new { Name = "Alfred Pennyworth", Hours = 40 , Pay = 35 , Department = "Wayne Enterprises"},
                new { Name = "Fish Mooney", Hours =40  , Pay =  33, Department = "Criminal Enterprises"},
                new { Name = "Oswald Cobblepot", Hours = 35 , Pay = 28 , Department = "Criminal Enterprises"},
                new { Name = "Harvey Bullock", Hours = 80 , Pay =  35, Department = "Gotham City PD"},
                new { Name = "Lucius Fox", Hours = 40 , Pay = 50 , Department = "Wayne Enterprises"}
            };
            // array for managers
            var managers = new[]
            {
                new { Name = "Don Carmine Falcone", Salary = 100000 , Office_Location = "Falcone Estate", Department_Supervised = "Criminal Enterprises"},
                new { Name = "Bruce Wayne", Salary =  1000000, Office_Location = "Wayne Manor", Department_Supervised = "Wayne Enterprises"},
                new { Name = "Jim Gordon", Salary = 88000 , Office_Location = "GCPD HQ", Department_Supervised = "Gotham City PD"}
            };
            // LINQ statement to join tables 
            var employeeQuery = from employee in employees
                                join manager in managers
                                on employee.Department equals manager.Department_Supervised
                                select new
                                {
                                    Name = employee.Name,
                                    managerName = manager.Name,
                                    Office = manager.Office_Location
                                };
            foreach (var e in employeeQuery)
            {
                // Initiates the random color 
              /*  Console.ForegroundColor =  GetRandomConsoleColor();*/

                //Cleaned up the print line to make it more readable and eye friendly
                Console.WriteLine($"\nEmployees Name: {e.Name} \n\t  Supervisors Name: {e.managerName} "
                    + $"\n\t  Supervisors Office Location: {e.Office}");
            }
            Console.ReadLine();
        }

        //Expirimenting with random color generator
        //works but sometimes text is black and cant see
        //learning on my own as well 

        /*private static Random rand = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(rand.Next(consoleColors.Length));
        }*/
    }
    }

