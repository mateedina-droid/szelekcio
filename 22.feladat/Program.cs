using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine((szam%3==0)?"Osztható 3-al matradék nélkül.": "Nem osztható 3-al matradék nélkül.");


            Console.ReadKey();

        }
    }
}
