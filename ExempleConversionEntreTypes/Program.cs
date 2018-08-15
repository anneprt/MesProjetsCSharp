using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleConversionEntreTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date de naissance ?");
            var saisie = Console.ReadLine();
            var dateNaissance = DateTime.Parse(saisie);
            var age = DateTime.Now.Date.Subtract(dateNaissance).Days / 365;

            Console.WriteLine($"Age:{age}");

            Console.ReadKey();
        }
    }
}
