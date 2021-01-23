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
    class Perishable
    {
        public string name;
        public int temperature;

        // 
        public string Name
        {
            get { return  name; }
            set { name = value; }
        }
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public Perishable(string name, int temperature)
        {
            this.name = name;
            this.temperature = temperature;
        }

        // ToString for storage instruction
        public override string ToString()
        {
            string str;
            str = string.Format($"{name} is perishable and should be kept at a temperature around {temperature}.");
            return str;
        }
    }
}
