using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public class CategorieVoiture
    {
        public CategorieVoiture()
        {
            Voitures = new List<Voiture>();
        }

        public string Nom { get; set; }
        public double PrixJour { get; set; }

        public List<Voiture> Voitures { get; set; }
    }
}
