using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVehicule
{
    class Voiture : Vehicule
    {
        public override int GetVitesseMax()
        {
            return 200;
        }
    }
}
