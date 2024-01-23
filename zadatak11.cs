using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj:");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            int drugiBroj = int.Parse(Console.ReadLine());

            int najveciDjeljiv = 1;

            for (int i = 1; i <= prviBroj && i <= drugiBroj; i++)
            {
                if (prviBroj % i == 0 && drugiBroj % i == 0)
                {
                    najveciDjeljiv = i;
                }
            }

            Console.WriteLine("Najveci broj s kojim su oba broja djeljiva: " + najveciDjeljiv);

            Console.ReadKey();
        }
    }
}
