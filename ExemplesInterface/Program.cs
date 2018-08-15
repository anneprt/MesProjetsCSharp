using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplesInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string chaine = "Bonjour";
            IComparable variable1 = chaine;
            IEnumerable<char> variable2 = chaine;

        }
    }
}
