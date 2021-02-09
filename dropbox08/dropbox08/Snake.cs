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
    class Snake
    {
        //Fields
        /* private int xPosition;
         private int yPosition;*/
        private List<int> xPosition;
        private List<int> yPosition;
        private int numberOfFruitEaten;
        // Properties
        public List<int> XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public List<int> YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public int NumberOfFruitEaten
        {
            get { return numberOfFruitEaten; }
            set { numberOfFruitEaten = value; }
        }
        //Constructor
        public Snake(List<int> xPosition, List<int> yPosition, int numberOfFruitEaten)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.numberOfFruitEaten = numberOfFruitEaten;
        }
        // Methods
        public void MoveLeft()
        {
            XPosition[0]--;
        }
        public void MoveRight()
        {
            XPosition[0]++;
        }
        public void MoveUp()
        {
            YPosition[0]--;
        }
        public void MoveDown()
        {
            YPosition[0]++;
        }
        //ToString Method
        public override string ToString()
        {
            Console.SetCursorPosition(XPosition[0], YPosition[0]);
            Console.WriteLine(((char)214).ToString());
            for (int i = 1; i <= NumberOfFruitEaten; i++)
            {
                Console.SetCursorPosition(XPosition[i], YPosition[i]);
                Console.Write("0");
            }
            return "";
        }
    }
}
