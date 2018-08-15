using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> infos = new List<string>();
            Console.WriteLine("Entrez votre prénom");
            infos.Add(Console.ReadLine());


            Console.WriteLine("Entrez votre nom");
            infos.Add(Console.ReadLine());


            Console.WriteLine("Entrez votre âge");
            infos.Add(Console.ReadLine());

            Console.WriteLine("Bonjour " + infos[0] + " " + infos[1] + ".Tu as " + infos[2] + " ans");

            var message = "Bonjour {0} { 1}.\n Tu as {2} ans";

            Console.WriteLine(message);

            Console.WriteLine("Quel est votre prénom ?");
            var prenom = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Quel est votre nom ?");
            var nom = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Quel est votre âge ?");
            var age = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Bonjour " + prenom + " " + nom + ".\nTu as " + age + "ans!");

            //Console.WriteLine("Bonjour {0} { 1}.\n Tu as {2} ans", prenom, nom, age);
            Console.WriteLine($"Bonjour {prenom} {nom}.\nTu as {age} ans!");

            Console.ReadKey();
        }
    }
}
