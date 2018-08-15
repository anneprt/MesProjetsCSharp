using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExempleLinq
{
    class Program
    {
        private static readonly int[] numeros = new int[] { 1, 3, 4, 6, 7, 8, 11, 15 };

        private static readonly string[] prenoms = new string[] {
            "Thierry", "Alexina", "Alexandre", "Frédéric",
            "Youcef", "Stéphane", "Laura", "Chi Trung", "Julien",
            "Cristtiano", "Hatem", "Laynet", "Anne", "Thi Tuong" };

        private static readonly List<ville> villes = new List<ville> {
            new ville { Nom = "Paris", CodePostal = "75013" },
            new ville { Nom = "Bordeaux", CodePostal = "33000" },
            new ville { Nom = "Mérignac", CodePostal = "33700" },
            new ville { Nom = "Floirac", CodePostal = "33270" },
            new ville { Nom = "Sarlat-La-Canéda", CodePostal = "24200" },
            new ville { Nom = "Bergerac", CodePostal = "24100" },
            new ville { Nom = "Périgueux", CodePostal = "24000" },
            new ville { Nom = "Marseille", CodePostal = "13000" },
        };

        private static readonly List<Departement> departements = new List<Departement> {
            new Departement { Nom = "Paris", Numero = "75" },
            new Departement { Nom = "Dordogne", Numero = "24" },
            new Departement { Nom = "Charente", Numero = "16" },
            new Departement { Nom = "Gironde", Numero = "33" },
        };


        static void Main(string[] args)
        {
            RequeteSimple();
            RequeteAvecFiltre();
            RequeteAvecTri();
            RequeteAvecGroupement();
            RequeteAvecGroupement2();
            RequeteAvecTypeDeRetourDifferent();
            RequeteAvecJointure();

            /*var requete = (from numero in numeros
                           where numero % 2 == 0
                           select numero).Except(new[] { 1, 6 });*/

            //Lire un fichier
            var cheminFichier = @"C:\Temp\villes.txt";
            if (File.Exists(cheminFichier))
            {
                IEnumerable<string> lignesFichier = File.ReadLines(cheminFichier);
                var villesDansFichier = new List<ville>();
                foreach (var ligneFichier in lignesFichier)
                {
                    string[] champs = ligneFichier.Split(';');
                    var ville = new ville();
                    ville.Nom = champs[0];
                    ville.CodePostal = champs[1];

                    villesDansFichier.Add(ville);
                }

            }
            else
            {
                //Ecrire
                var contenuFichier = new StringBuilder();
                foreach (var ville in villes)
                {
                    //contenuFichier.AppendLine($"{ville.Nom};{ville.CodePostal}");
                    contenuFichier.AppendLine(string.Join(";", ville.Nom, ville.CodePostal));

                }
                File.WriteAllText(cheminFichier, contenuFichier.ToString());

            }
            Console.ReadKey();
        }

        private static void RequeteSimple()
        {
            AfficherEntete();

            // Syntaxe de requête
            var requete = from prenom in prenoms
                          select prenom;
            foreach (var resultat in requete)
                Console.WriteLine(resultat);
            Console.WriteLine("*************************");

            // Syntaxe de méthode
            var requete2 = prenoms.Select(prenom => prenom);
            foreach (var resultat in requete2)
                Console.WriteLine(resultat);
        }

        private static void RequeteAvecFiltre()
        {
            AfficherEntete();

            // Syntaxe de requête
            var requete = from prenom in prenoms
                          where prenom.StartsWith("A")
                          select prenom;
            foreach (var resultat in requete)
                Console.WriteLine(resultat);
            Console.WriteLine("*************************");

            // Syntaxe de méthode
            var requete2 = prenoms.Where(prenom => prenom.StartsWith("A"))
                            .Select(prenom => prenom);
            foreach (var resultat in requete2)
                Console.WriteLine(resultat);
        }

        private static void RequeteAvecTri()
        {
            AfficherEntete();

            // Syntaxe de requête
            var requete = from prenom in prenoms
                          orderby prenom descending
                          select prenom;
            foreach (var resultat in requete)
                Console.WriteLine(resultat);
            Console.WriteLine("*************************");

            // Syntaxe de méthode
            var requete2 = prenoms.OrderByDescending(prenom => prenom)
                                   .Select(prenom => prenom);
            foreach (var resultat in requete2)
                Console.WriteLine(resultat);
        }

        private static void RequeteAvecGroupement()
        {
            AfficherEntete();

            // Syntaxe de requête
            var requete = from prenom in prenoms
                          orderby prenom ascending
                          group prenom by prenom[0] into groupe
                          select new
                          {
                              Lettre = groupe.Key,
                              Prenoms = groupe.ToList()
                          };
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat.Lettre);
                foreach (var prenom in resultat.Prenoms)
                {
                    Console.WriteLine($"\t{prenom}");
                }
            }
            Console.WriteLine("*************************");

            // Syntaxe de méthode
            var requete2 = prenoms
                        .OrderBy(prenom => prenom)
                        .GroupBy(prenom => prenom[0])
                        .Select(groupe => new
                        {
                            Lettre = groupe.Key,
                            Prenoms = groupe.ToList()
                        });
            foreach (var resultat in requete2)
            {
                Console.WriteLine(resultat.Lettre);
                foreach (var prenom in resultat.Prenoms)
                {
                    Console.WriteLine($"\t{prenom}");
                }
            }
        }

        private static void RequeteAvecGroupement2()
        {
            AfficherEntete();

            // Syntaxe de requête
            var requete = from ville in villes
                          orderby ville.Nom ascending
                          group ville by ville.Departement into groupe
                          select new
                          {
                              NumeroDepartement = groupe.Key,
                              Villes = groupe.ToList()
                          };
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat.NumeroDepartement);
                foreach (var ville in resultat.Villes)
                {
                    Console.WriteLine($"  - {ville.Nom} ({ville.CodePostal})");
                }
            }
            Console.WriteLine("*************************");

            // Syntaxe de méthode
            var requete2 = villes
                        .OrderBy(x => x.Nom)
                        .GroupBy(x => x.Departement)
                        .Select(groupe => new
                        {
                            NumeroDepartement = groupe.Key,
                            Villes = groupe.ToList()
                        });
            foreach (var resultat in requete2)
            {
                Console.WriteLine(resultat.NumeroDepartement);
                foreach (var ville in resultat.Villes)
                {
                    Console.WriteLine($"  - {ville.Nom} ({ville.CodePostal})");
                }
            }
        }

        private static void RequeteAvecTypeDeRetourDifferent()
        {
            AfficherEntete();

            // Syntaxe de requête


            // Syntaxe de méthode
        }

        private static void RequeteAvecJointure()
        {
            AfficherEntete();

            // Syntaxe de requête
            var requete = from ville in villes
                          join departement in departements on ville.Departement equals departement.Numero
                          //into jointure
                          //from ligne in jointure.DefaultIfEmpty()
                          select new
                          {
                              Ville = ville.Nom,
                              //NomDepartement=ligne?.Nom
                              NomDepartement = departement.Nom
                          };
            foreach (var resultat in requete)
            {
                Console.WriteLine($" - {resultat.Ville} ({resultat.NomDepartement})");
            }

            Console.WriteLine("*************************");


            // Syntaxe de méthode

            var requete2 = villes
                .Join(
                
                    departements,
                    ville => ville.Departement,
                    departement => departement.Numero,
                    (ville, departement) => new
                    {
                        Ville = ville.Nom,
                        NomDepartement = departement.Nom
                    });

            foreach (var resultat in requete2)
            {
                Console.WriteLine($" - {resultat.Ville} ({resultat.NomDepartement})");
            }



        }

        private static void AfficherEntete([CallerMemberName]string nomMethodeAppelant = null)
        {
            Console.WriteLine();
            Console.WriteLine(nomMethodeAppelant);
            Console.WriteLine(new string('-', 60));
        }

    }
}
