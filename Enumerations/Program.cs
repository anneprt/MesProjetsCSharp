using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            var evenement = new Evenement();
            evenement.JourSemaine = JourSemaine.Mardi;
            Console.WriteLine(evenement.JourSemaine);
            Console.ReadKey();
        }
    }
}
