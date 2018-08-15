using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoTVA
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal prixBrut1 = 12.80m;
            decimal prixBrut2 = 100m;
            decimal prixBrut3 = 70.30m;

            //var prixNet1 = CalculerPrixNet(prixBrut1);
            //var prixNet2 = CalculerPrixNet(prixBrut2);
            //var prixNet3 = CalculerPrixNet(prixBrut3);

            Console.WriteLine($"Le prix net 1 est: {CalculerPrixNet(prixBrut1)} euros");
            Console.WriteLine($"Le prix net 2 est: {CalculerPrixNet(prixBrut2)} euros");
            Console.WriteLine($"Le prix net 3 est: {CalculerPrixNet(prixBrut3)} euros");

            Console.ReadKey();
        }

        static decimal CalculerPrixNet(decimal prixBrut)
        {
            decimal Tva= 20m;
            return prixBrut + (prixBrut* Tva/100);
            //decimal montantTVA;
            //decimal montantTTC;
            //decimal prixBrut;
            //const TVA= 20 / 100;
            //montantTVA = prixBrut * TVA;
            //montantTTC = prixBrut + montantTVA;
            //return montantTTC;            
        }
    }
}
