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
    abstract class Movie
    {
        // Fields
        private string title;
        private string directors;


        // Field Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Directors
        {
            get { return directors; }
            set { directors = value; }
        }
        // Class Constructor
        public Movie(string title, string directors)
        {
            this.title = title;
            this.directors = directors;
        }

        // Methods
        public abstract decimal DisplayPrice();

        // ToString() Method
        public override string ToString()
        {
            string str;
            str = string.Format($"Movie Title: {Title}\nDirectors: {Directors}");
            return str;
        }
    }
}
