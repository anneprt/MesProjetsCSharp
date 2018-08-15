using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExos
{
    class Program
    {
        private static int[] scores = new int[] { 97, 92, 81, 60 };

        static void Main(string[] args)
        {


            ScoreSuperieur();
            ScoreOrdreCroissant();
            FrequenceMammouth();
            Console.ReadKey();

        }

        private static void ScoreSuperieur()



        //Syntaxe de requête
        {
            AfficherEntete("Scores supérieurs à 80");
            var requete = from score in scores
                          where score > 80
                          select score;
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat);
            }
            //Syntaxe de méthode
            {
                AfficherEntete("Scores supérieurs à 80");
                var requete2 = scores.Where(score => score > 80)
                    .Select(score => score);
                foreach (var resultat in requete2)
                {
                    Console.WriteLine(resultat);
                }

            }
        }
        private static void ScoreOrdreCroissant()



        //Syntaxe de requête
        {
            AfficherEntete("Scores rangés par ordre croissant");
            var requete3 = from score in scores
                           orderby score ascending
                           select score;
            foreach (var resultat in requete3)
            {
                Console.WriteLine(resultat);
            }
            //Syntaxe de méthode
            {
                AfficherEntete("Scores rangés par ordre croissant");
                var requete4 = scores.OrderBy(score => score)
                    .Select(score => score);
                foreach (var resultat in requete4)
                {
                    Console.WriteLine(resultat);
                }

            }


        }
        private static void AfficherResultats<T>(IEnumerable<T> resultats)
        {
            foreach (var resultat in resultats)
            {
                Console.WriteLine(resultat);
            }
        }

        private static void AfficherEntete(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void FrequenceMammouth()

        //syntaxe de requete
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----Quelle est la fréquence des lettres dans le mot ?-----");
            Console.WriteLine(" ");
            Console.WriteLine("Entrez un mot:");
            Console.ResetColor();
            string mot = Console.ReadLine();

            var requete = from lettre in mot.ToCharArray()
                          group lettre by lettre;

            foreach (var resultat in requete)
            {
                Console.WriteLine($"{resultat.Key} => {resultat.Count()}");
            }

        }
        



    }
}


