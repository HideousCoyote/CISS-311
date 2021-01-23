/*Mark Chambers
    CISS_311
    Advanced Agile Development
    1/20/2021*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox04
{
    class NonPerishable
    {
        public string name;
        public DateTime expiration;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Expiration
        {
            get { return expiration; }
            set { expiration = value; }
        }

        //Constructor
        public NonPerishable(string name, DateTime expiration)
        {
            this.name = name;
            this.expiration = expiration;
        }
        // ToString for storage instruction
        public override string ToString()
        {
            string str;
            str = string.Format($"{name} must be consumed before {expiration}.");
            return str;
        }
    }
}
