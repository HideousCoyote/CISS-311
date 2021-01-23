// Mark Chambers
// CISS-311
// Advanced Agile Development
// 1/14/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox02
{
    class NewRelease : Movie
    {
        // Field
        private int daysInTheatre;
        // FIeld Property
        public int DaysInTheatre
        {
            get { return daysInTheatre; }
            set { daysInTheatre = value; }
        }
        // Class Constructor
        public NewRelease(string title, string directors, int daysInTheatre)
            : base(title, directors)
        {
            if (daysInTheatre < 0)
                throw new ArgumentOutOfRangeException("Days in Theatre cannot be a negative number.");
            this.daysInTheatre = daysInTheatre;
        }
        // method to override displayPrice()
        public override decimal DisplayPrice()
        {
            decimal price;
            if (daysInTheatre <= 36)
                price = 20m - 0.5m * (daysInTheatre);
            else
                price = 2.0m;
            return price;
        }
        // ToString() method
        public override string ToString()
        {
            string str;
            str = string.Format("New Release:\n") +
                base.ToString() +
                string.Format($"Days In Theatre: {DaysInTheatre}\nPrice: {DisplayPrice():C}");
            return str;
        }
    }
}
