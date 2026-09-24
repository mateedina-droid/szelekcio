using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot:  ");
            int szam = int.Parse(Console.ReadLine());
            Console.Write("Kérek egy másik számot:  ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine((szam>szam2)?szam-szam2:szam2-szam);


            Console.ReadKey();


        }
    }
}
