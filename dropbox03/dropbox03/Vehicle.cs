/*Mark Chambers
CISS-311
Advanced Agile Development
1/17/2020*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox03
{
    class Vehicle
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public char VehicleSymbol { get; set; }
        public ConsoleColor VehicleColor { get; set; }
        public int Speed { get; set; }

        // Constructor
        public Vehicle(int xPosition, int yPosition, char vehicleSymbol, 
            ConsoleColor vehicleColor, int speed)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            VehicleSymbol = vehicleSymbol;
            VehicleColor = vehicleColor;
            Speed = speed;
        }
        // Methods
        public void MoveLeft()
        {
            XPosition--;
        }
        public void MoveRight()
        {
            XPosition++;
        }
        public void Accelerate()
        {
            Speed += 10;
        }
        public void Brake()
        {
            Speed -= 10;
        }
    }
}
