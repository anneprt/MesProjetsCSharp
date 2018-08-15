using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public sealed class Agence
    {
        public Agence()
        {
            Parc = new List<Vehicule>();
            Personnel = new List<Employe>();
        }

        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }

        public List<Employe> Personnel { get; set; }
        public List<Vehicule> Parc { get; set; }
    }
}
