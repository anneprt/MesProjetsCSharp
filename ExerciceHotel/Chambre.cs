using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel
{
    public class Chambre
    {
        public string Numero { get; set; }
        public int NombresLits { get; set; }
        public decimal PrixNuitee { get; set; }

        public List<Reservation> Reservation { get; set; }
        public Hotel Hotel { get; set; }
    }
}
