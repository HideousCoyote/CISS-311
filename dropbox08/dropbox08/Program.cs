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
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "dropbox08";
            Console.CursorVisible = false;
            int numberOfFruitEaten = 0;
            List<int> xPosition = new List<int>();
            List<int> yPosition = new List<int>();
            xPosition.Add(25);
            yPosition.Add(20);
            Snake snake = new Snake(xPosition, yPosition, numberOfFruitEaten);
            Console.SetCursorPosition(snake.XPosition[0], snake.YPosition[0]);
            Console.WriteLine(((char)214).ToString());
            bool isEaten = false;
            Fruit fruit = new Fruit();
            Console.WriteLine(fruit);
            ConsoleKey playerKey = Console.ReadKey().Key;
            do
            {
                Console.SetCursorPosition(snake.XPosition[numberOfFruitEaten],
                    snake.YPosition[numberOfFruitEaten]);
                Console.WriteLine(" ");
                if (snake.XPosition[0] == fruit.XPosition &&
                    snake.YPosition[0] == fruit.YPosition)
                    isEaten = true;
                if (isEaten)
                {
                    Console.WriteLine(fruit);
                    isEaten = false;
                    numberOfFruitEaten++;
                    snake.XPosition.Add(snake.XPosition[0]);
                    snake.YPosition.Add(snake.YPosition[0]);
                    
                }
                List<int> xold = snake.XPosition;
                List<int> yold = snake.YPosition;
                snake.NumberOfFruitEaten = numberOfFruitEaten;
                for (int j = numberOfFruitEaten;  j > 0;  j--)
                {
                    xold[j] = xold[j - 1];
                    yold[j] = yold[j - 1];
                }
                if (playerKey == ConsoleKey.LeftArrow)
                    snake.MoveLeft();
                else if (playerKey == ConsoleKey.RightArrow)
                    snake.MoveRight();
                else if (playerKey == ConsoleKey.UpArrow)
                    snake.MoveUp();
                else if (playerKey == ConsoleKey.DownArrow)
                    snake.MoveDown();
                Console.WriteLine(snake);
                snake.XPosition = xold;
                snake.YPosition = yold;
                if (Console.KeyAvailable)
                    playerKey = Console.ReadKey().Key;
                System.Threading.Thread.Sleep(240);
            } while (playerKey == ConsoleKey.LeftArrow ||
            playerKey == ConsoleKey.RightArrow ||
            playerKey == ConsoleKey.UpArrow ||
            playerKey == ConsoleKey.DownArrow);
            Console.ReadKey();
         }
        }
    }

