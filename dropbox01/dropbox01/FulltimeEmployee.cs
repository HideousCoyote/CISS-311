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
    class FulltimeEmployee : Employee
    {
        // Fields
        private decimal salary;

        // Constructor
        public FulltimeEmployee(string name, string socialSecurityNumber, decimal salary)
            : base (name, socialSecurityNumber)
        {
            this.salary = salary;
        }

        // Property
        public decimal Salary 
        {
            get { return salary; }
            set { salary = value; } 
        }

        // Must override the Paycheck() method
        public override decimal Paycheck()
        {
            decimal payAmount;
            payAmount = Salary / 52;
            return payAmount;
        }

        // ToString method
        public override string ToString()
        {
            string str;
            str = string.Format("Fulltime Employee:\n") +
                base.ToString() +
                string.Format($"\nPay Amount: {Paycheck():C}");
            return str;
        }
    }
}
