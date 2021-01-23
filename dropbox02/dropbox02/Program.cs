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
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dropbox02";
            //List to hold all the movies
            List<Movie> allMovies = new List<Movie>();

            // Add NewReleases to the allMovies List
            allMovies.Add(new NewRelease("Wonder Woman", "Patty Jenkins", 0));
            allMovies.Add(new NewRelease("Spider-man: Homecoming", "Jon Watts", 3));

            allMovies.Add(new Classic("Roundhay Garden Scene", "Louis Le Prince", 1888, 95));
            allMovies.Add(new Classic("The Godfather", "Francis Ford Coppola", 1972, 100));
            allMovies.Add(new Classic("Gone with the Wind", "Victor Fleming, George Cukor, Sam Wood", 1940, 105));


            // Display all movies added to allMovies List
            foreach (Movie m in allMovies)
            {
                Console.WriteLine(m + "\n");
            }
            // Tomorrows prices for new releases
            Console.WriteLine("Tomorrow's price for new Release Movies are:");
            foreach(Movie m in allMovies)
            {
                if(m is NewRelease)
                {
                    // Cast down m to NewReleases
                    NewRelease nm = (NewRelease)m;
                    nm.DaysInTheatre = nm.DaysInTheatre + 1;
                    Console.WriteLine($"{nm.Title} price will be {nm.DisplayPrice():C}");
                }
            }
            Console.ReadKey();
        }
    }
}
