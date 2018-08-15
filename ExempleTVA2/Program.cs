using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleTVA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Prix TTC de l'article: {CalculerPrixNet(.95m)} euros");
            Console.WriteLine($"Prix TTC de l'article: {CalculerPrixNet(45.95m)} euros");
            Console.WriteLine($"Prix TTC de l'article: {CalculerPrixNet(100) }euros");

            Console.ReadKey();
        }

        static decimal CalculerPrixNet(decimal prixHT)
        {
            return prixHT * 1.206m;
        }

    }
}
