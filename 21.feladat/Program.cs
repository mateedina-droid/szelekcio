using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("Páros");
            }
            else if (szam % 2 == 1)
            {
                Console.WriteLine("Páratlan");
            }
            else
            {
                Console.WriteLine("nulla");
            }
            Console.ReadKey();
        }
    }
}
