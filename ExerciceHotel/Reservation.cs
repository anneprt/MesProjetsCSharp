using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel
{
   public class Reservation
    {
        public DateTime DateDebut { get; set; }
        public int NombreNuitees { get; set; }

        public Client Client { get; set; }
        public Chambre Chambre { get; set; }
    }
}
