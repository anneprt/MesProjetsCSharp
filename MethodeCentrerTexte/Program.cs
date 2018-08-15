using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeCentrerTexte
{
    class Program
    {
        static void Main(string[] args)
        {
            CentrerLeTexte("Hello world");
            CentrerLeTexte("Je suis un texte plus long");
        }
        private static void CentrerLeTexte(string texte)
        {
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }
    }
}
