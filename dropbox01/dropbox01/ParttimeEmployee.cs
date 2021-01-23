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
    class ParttimeEmployee : Employee
    {
        // Fields
        private decimal wage;
        private decimal hour;

        //Constructor
        public ParttimeEmployee (string name, string socialSecurityNumber, decimal wage, decimal hour)
            : base (name, socialSecurityNumber)
        {
            this.wage = wage;
            this.hour = hour;
        }

        // Properties
        public decimal Wage 
        {
            get { return wage; }
            set { wage = value; } 
        }

        public decimal Hour 
        {
            get { return hour; }
            set { hour = value; } 
        }

        // Overried the Paycheck() method
        public override decimal Paycheck()
        {
            decimal payAmount;
            payAmount = Wage * Hour;
            return payAmount;
        }

        // ToString method
        public override string ToString()
        {
            string str;
            str = string.Format("Parttime Employee:\n") +
                base.ToString() + 
                string.Format($"\nPay Amount: {Paycheck():C}");
            return str;
        }
    }
}
