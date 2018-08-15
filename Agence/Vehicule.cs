using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public abstract class Vehicule
    {
        public string Marque { get; set; }
        public string Modele { get; set; }

        public abstract double GetPrixJour();
    }
}
