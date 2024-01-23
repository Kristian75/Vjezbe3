using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");
            string nizZnakova = Console.ReadLine();

            int[] brojac = new int[256];

            foreach (char znak in nizZnakova)
            {
                brojac[znak]++;
            }

            int maxBrojac = 0;
            char najcesciZnak = ' ';

            for (int i = 0; i < 256; i++)
            {
                if (brojac[i] > maxBrojac)
                {
                    maxBrojac = brojac[i];
                    najcesciZnak = (char)i;
                }
            }

            Console.WriteLine("\nNajcesci znak: " + najcesciZnak);
            Console.WriteLine("Broj ponavljanja: " + maxBrojac);

            Console.ReadKey();
        }
    }
}
