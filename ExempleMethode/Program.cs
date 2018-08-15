using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            var prenom = PoserQuestion("Quel est votre prénom?");
            var nom = PoserQuestion("Quel est votre nom ?");
            var age = PoserQuestion("Quel est votre âge ?");

            Console.WriteLine($"Bonjour {prenom} {nom}.\nTu as {age} ans.");
            //le$ permet de mettre les variables dans le texte
            Console.ReadKey();
        }
        static string PoserQuestion(string question)
        {
            Console.WriteLine(question);
            var saisie = Console.ReadLine();
            Console.Clear();
            //Console.WriteLine($"Valeur: {saisie}");

            return saisie;
        }
    }
}
