using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresControle
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodeAvecElseIf();
            MethodeAvecSwitch();
            MethodeAvecSwitchBis();
            MethodeAvecFor();
            MethodeAvecWhile();
            MethodeAvecWhile2();
            MethodeAvecDoWhile();

        }

        static void MethodeAvecElseIf()
        {
            Console.WriteLine("entrez un nombre");
            string nombre = Console.ReadLine();
            int nombreParsé = int.Parse(nombre);
            string reponse;

            if (nombreParsé > 0)
            {
                reponse = "nombre positif";

            }
            else if (nombreParsé < 0)
            {
                reponse = "nombre négatif";
            }

            else
            {
                reponse = "rien à dire";
            }

            Console.WriteLine(reponse);
        }

        static void MethodeAvecSwitch()
        {
            string message = "tu es ";
            Console.WriteLine("quelle est votre dénomination ?");

            string saisie = Console.ReadLine();

            switch (saisie)
            {
                case "Mademoiselle":
                case "Madame":
                    message += "la bienvenue!";
                    break;

                default:
                    message += "le bienvenu !";
                    break;

            }
            Console.WriteLine(message);

        }

        static void MethodeAvecSwitchBis()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string message = "cette devise est ";
            Console.WriteLine("entrez le symbole de votre devise ?");

            string saisie = Console.ReadLine();

            switch (saisie)
            {
                case "€":
                    message += "l'euro";
                    break;

                case "$":
                    message += "le dollar";
                    break;

                case "£":
                    message += "la livre sterling";
                    break;

                default:
                    message += "inconnue !";
                    break;

            }
            Console.WriteLine(message);
            Console.ReadKey();

        }

        static void MethodeAvecFor()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    if (i < 20)
                    {
                        Console.Write(", ");

                    }
                    else
                    {
                        Console.Write(".\n");
                    }
                }
            }
        }

        static void MethodeAvecWhile()
        {
            int i = 1;

            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    if (i < 20)
                    {
                        Console.Write(", ");

                    }
                    else
                    {
                        Console.Write(".\n");
                    }
                }
                i++;
            }
        }

        static void MethodeAvecWhile2()
        {
            Console.WriteLine("Entre un nombre");

            while (Console.ReadLine() != "2018")
            {
                Console.WriteLine("rentrer une nouvelle valeur");
            }
            Console.WriteLine("Bravo la réponse était 2018");
        }

        static void MethodeAvecDoWhile()
        {
            string input;


            do
            {
                Console.WriteLine("Entre un nombre");
                input = Console.ReadLine();

            } while (input != "2018");
            Console.WriteLine("Bravo la réponse était 2018");
        }

    }
}
