using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVehicule
{
    public class Avion : Vehicule
    {
        public Avion()
            {

           this.NumeroSerie="";
            }

        public int NombreMoteurs { get; set; }
        
        public override int GetVitesseMax()
        {
            return 1200;
        }
    }
}
