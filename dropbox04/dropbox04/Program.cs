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
    class Program
    {
        static void Main(string[] args)
        {
           /* Create and add foods to be printed
                I added more to see how it works.*/

            Perishable e = new Perishable("Egg", 45);
            Perishable m = new Perishable("Milk", 38);

            NonPerishable r = new NonPerishable("White Rice", new DateTime(2020, 5, 17));
            NonPerishable cb = new NonPerishable("Canned Beans", new DateTime(2020, 4, 21));
            // Display all
            DisplayInstruction<Perishable>(e);
            DisplayInstruction<Perishable>(m);
            DisplayInstruction<NonPerishable>(cb);
            DisplayInstruction<NonPerishable>(r);
            Console.ReadKey();
        }
        static void DisplayInstruction<E>(E e)
        { 
            Console.WriteLine(e + "\n");
        }
    }
}
