/*Mark Chambers
CISS-311
Advanced Agile Development
1/17/2020*/

using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections;
using System.Diagnostics;
namespace dropbox03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "dropbox03";
            // create an instance of stopwatch and strart
            Stopwatch sw = new Stopwatch();
            sw = Stopwatch.StartNew();
           
            
            Console.CursorVisible = false;
            const int ROAD_WIDTH = 20;
            Vehicle playerVehicle =
                new Vehicle(10, 20, '^', ConsoleColor.Cyan, 0);
            /*   Vehicle oppositeDirectionVehicle =
                   new Vehicle(10, 0, '8', ConsoleColor.Green, 0);*/

            // create an instance of random and a vehicle list 
            Random random = new Random();
            List<Vehicle> vehicleList = new List<Vehicle>();
            while (true)
            {
               /* if (playerVehicle.XPosition == oppositeDirectionVehicle.XPosition
                    && playerVehicle.YPosition == oppositeDirectionVehicle.YPosition)
                {
                    Display(playerVehicle.XPosition, playerVehicle.YPosition,
                        ConsoleColor.Red, "X: ");
                    Display(playerVehicle.XPosition + 2, playerVehicle.YPosition,
                        ConsoleColor.White, "Accident\nPress Enter to Quit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }*/

               // clears the player vehicles last location upon moving
                Console.Clear();
                /*if (oppositeDirectionVehicle.YPosition
                    < Console.WindowHeight - 1)
                    oppositeDirectionVehicle.YPosition++;
                else
                    oppositeDirectionVehicle.YPosition = 1;
                Display(oppositeDirectionVehicle.XPosition,
                    oppositeDirectionVehicle.YPosition,
                    oppositeDirectionVehicle.VehicleColor,
                    oppositeDirectionVehicle.VehicleSymbol);
                Display(playerVehicle.XPosition, playerVehicle.YPosition,
                    playerVehicle.VehicleColor, playerVehicle.VehicleSymbol);*/
                int newVehiclePosition = random.Next(ROAD_WIDTH);
                Vehicle vehicle = new Vehicle(newVehiclePosition, 0, '8', ConsoleColor.Green, 0);
                vehicleList.Add(vehicle);
                foreach (var oppositeDirectionVehicle in vehicleList)
                {
                    // if statement to check if vehicles are in the same position for crash
                    if (playerVehicle.XPosition == oppositeDirectionVehicle.XPosition
                   && playerVehicle.YPosition == oppositeDirectionVehicle.YPosition)
                    {
                        // Stop the stopwatch
                        sw.Stop();
                        // Display the crash
                        Display(playerVehicle.XPosition, playerVehicle.YPosition,
                            ConsoleColor.Red, "X: ");
                        Display(playerVehicle.XPosition + 2, playerVehicle.YPosition,
                            ConsoleColor.White, "Accident\nPress Enter to Quit\n");
                        // print the time before accident
                        Console.WriteLine($"You made it: {sw.ElapsedMilliseconds  / 1000} seconds before an accident.");
                        
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if (oppositeDirectionVehicle.YPosition
                    < Console.WindowHeight - 1)
                        oppositeDirectionVehicle.YPosition++;
                    else
                        oppositeDirectionVehicle.YPosition = 1;
                    Display(oppositeDirectionVehicle.XPosition,
                        oppositeDirectionVehicle.YPosition,
                        oppositeDirectionVehicle.VehicleColor,
                        oppositeDirectionVehicle.VehicleSymbol);
                    Display(playerVehicle.XPosition, playerVehicle.YPosition,
                        playerVehicle.VehicleColor, playerVehicle.VehicleSymbol);
                }
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (playerVehicle.XPosition >= 1)
                            playerVehicle.MoveLeft();
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (playerVehicle.XPosition + 1 < ROAD_WIDTH)
                            playerVehicle.MoveRight();
                    }
                    else if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        if (playerVehicle.Speed + 10 < 200)
                            playerVehicle.Accelerate();
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        if (playerVehicle.Speed - 10 > 0)
                            playerVehicle.Brake();
                    }
                }
                Thread.Sleep(200 - playerVehicle.Speed);
            }
        }
        static void Display<E>(int x, int y, ConsoleColor c, E e)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = c;
            Console.Write(e);
        }
    }
}
