using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel
{
    public class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
