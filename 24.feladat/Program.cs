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
            if (szam == 1 || szam == 2 || szam == 12)
                Console.WriteLine("Téli hónap");
            else if (szam == 3 || szam == 4 || szam == 5)
                Console.WriteLine("Tavaszi hónap");
            else if (szam == 6 || szam == 7 || szam == 8)
                Console.WriteLine("Nyári hónap");
            else if (szam == 9 || szam == 10 || szam == 11) 
                Console.WriteLine("Őszi hónap");
            else
                Console.WriteLine("Nincs ilyen hónap");

            Console.ReadKey();

        }
    }
}
