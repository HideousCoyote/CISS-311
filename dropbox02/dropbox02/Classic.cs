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
    class Classic : Movie
    {
        // Fields
        private int yearReleased;
        private int todayTemperature;
        // Field Properties
        public int YearReleased
        {
            get { return yearReleased; }
            set { yearReleased = value; }
        }
        public int TodayTemperature
        {
            get { return todayTemperature; }
            set { todayTemperature = value; }
        }
        // Class Constructor
        public Classic(string title, string directors, int yearReleased, int todayTemperature)
            : base (title, directors) // pulls fields shared from abstract class Movie
        {
            if (yearReleased < 1888)
                throw new ArgumentOutOfRangeException("No movie before that year.");
            this.yearReleased = yearReleased;
            this.todayTemperature = todayTemperature;
        }
        //override DisplayPrice() method
        public override decimal DisplayPrice()
        {
            decimal price;
            if (todayTemperature > 95)
                price = 2.0m - 2.0m * (todayTemperature - 95) * 0.01m;
            else
                price = 2.0m;
            return price;
        }
        //ToString() Method
        public override string ToString()
        {
            string str;
            str = string.Format("Classic Movie:\n") +
                base.ToString() +
                string.Format($"Year Released: {YearReleased}\nPrice: {DisplayPrice():C}");
            return str;
        }

    }
}
