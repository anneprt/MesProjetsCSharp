using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public sealed class Camionette : Vehicule
    {
        public int PoidsMaxEnKilos { get; set; }
        public int PrixJour { get; set; }

        public override double GetPrixJour()
        {
            return PrixJour;
        }
    }
}
