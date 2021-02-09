/*Mark Chambers
CISS-311
Advanced Agile Development
02/01/2021*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox08
{
    class Fruit
    {
        // Fields
        private int xPosition;
        private int yPosition;

        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public override string ToString()
        {
            Random random = new Random();
            XPosition = random.Next(2, Console.WindowWidth - 2);
            YPosition = random.Next(2, Console.WindowHeight - 2);
            Console.SetCursorPosition(XPosition, YPosition);
            return ((char)64).ToString();
        }
    }
}
