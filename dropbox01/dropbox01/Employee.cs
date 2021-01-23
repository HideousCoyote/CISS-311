// Mark Chambers
// CISS-311
// Advanced Agile Development
// 1/14/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox01
{
    abstract class Employee
    {
        
        // Fields
        private string name;
        private readonly string socialSecurityNumber;

        // Properties
         public string Name 
         {
          get { return name; }
          set { value = name; } 
         }
       
        // Constructors
        public Employee(String name, string socialSecurityNumber)
        {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
        }

        // Abstract Method
        public abstract decimal Paycheck();

        //ToString Method
        public override string ToString()
        {
            string str;
            str = string.Format($"Employee Name: {name}" +
                $"\nSocial Security Number: {socialSecurityNumber}");
            return str;
        }
    }
}
