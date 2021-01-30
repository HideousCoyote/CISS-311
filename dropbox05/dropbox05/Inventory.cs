/*Mark Chambers
    CISS-311
    Advanced Agile Development
    1/25/2021*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox05
{
    class Inventory
    {
        // fields
        private string sku;
        private string iName;
        private int numOnHand;

        public string SKU
        {
            get { return sku; }
            set { sku = value; }
        }
        public string IName
        {
            get { return iName; }
            set { iName = value; }
        }
        public int NumOnHand
        {
            get { return numOnHand; }
            set { numOnHand = value; }
        }
        // Constructor
        public Inventory(string sku, string iName, int numOnHand)
        {
            this.sku = sku;
            this.iName = iName;
            this.numOnHand = numOnHand;
            }
        // ToString Method
        public override string ToString()
        {
            string str;
            str = string.Format($"Product SKU:  {SKU},") +
                string.Format($"Product Name:  {IName},") +
                string.Format($"{"Number on Hand: "}" +
                $" {NumOnHand}");
            return str;
        }

    }
}
