using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            bool monBooleen = true;
            int monEntier = 14;
            string maChaineDeCaracteres = "On essaie de programmer";
            DateTime date = DateTime.Now;

            Console.WriteLine("Aujourd'hui nous sommes le " + date);
            Console.WriteLine("Nous sommes " + monEntier + " dans la classe." + maChaineDeCaracteres + " mais ce n'est pas évident. Ceci est " + monBooleen);

            string[] prenoms = new string[3];
            Console.WriteLine("Nom1");
            prenoms[0] = Console.ReadLine();
            Console.WriteLine("Nom2");
            prenoms[1] = Console.ReadLine();
            Console.WriteLine("Nom3");
            prenoms[2] = Console.ReadLine();
            Console.WriteLine(prenoms[0]);
            Console.WriteLine(prenoms[1]);
            Console.WriteLine(prenoms[2]);

            ArrayList prenomsDynamiques = new ArrayList();
            Console.WriteLine("Nom1");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine("Nom2");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine("Nom3");
            prenomsDynamiques.Add(Console.ReadLine());

            Console.WriteLine(prenomsDynamiques[0]);
            Console.WriteLine(prenomsDynamiques[1]);
            Console.WriteLine(prenomsDynamiques[2]);

            Console.ReadKey();
        }
    }
}
