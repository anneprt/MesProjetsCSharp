using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleParse
{
    class Program
    {
        public static void Main(string[] args)
        {
            int titi = SaisirEntier("12");

            Console.WriteLine(titi);


             int SaisirEntier(string v)
            {
                return int.Parse(v);
            }
        }
    }
}
