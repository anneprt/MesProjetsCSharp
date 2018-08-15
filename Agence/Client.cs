using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
   public class Client : Personne
    {
        public Client()
        {
            Contrats = new List<ContratLocation>();
        }

        public string Numero { get; set; }

        public List<ContratLocation> Contrats { get; set; }
    }
}
