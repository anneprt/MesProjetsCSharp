using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVehicule
{
    public abstract class Vehicule
    {
        public int NombreRoues { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public abstract int GetVitesseMax();
        public string NumeroSerie { get; set; }

        
    }
}
