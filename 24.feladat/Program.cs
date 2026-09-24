using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy hónap számát: ");
            int szam = int.Parse(Console.ReadLine());
            if (szam == 1 || szam == 2 )
                Console.WriteLine("Téli hónap");

        }
    }
}
