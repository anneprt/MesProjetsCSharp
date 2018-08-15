using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
   public sealed class Voiture : Vehicule
    {
        public int NombrePortes { get; set; } = 5;

        public CategorieVoiture Categorie { get; set; }

        public override double GetPrixJour()
        {
            return Categorie.PrixJour;
        }
    }
}
