using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList listeCourse = new ArrayList (); ne pas faire comme ça car n'appelle pas forcément une chaîne de caractères !

            List<string> listeCourse = new List<string>();
            Console.WriteLine("Entrez un premier produit manquant");
            listeCourse.Add(Console.ReadLine());

            Console.WriteLine("Entrez un second produit manquant");
            listeCourse.Add(Console.ReadLine());

            Console.WriteLine("Entrez un troisième produit manquant");
            listeCourse.Add(Console.ReadLine());

            Console.WriteLine("le deuxième élément de la liste de course est " + listeCourse[2]);

            Console.ReadKey();
        }
    }
}
