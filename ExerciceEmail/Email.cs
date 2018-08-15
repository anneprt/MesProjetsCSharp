using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceEmail
{
   public class Email
    {
        public string Sujet { get; set; }
        public string Destinataire { get; set; }
        public List<string> DestinataireEnCopie { get; set; }
        public string Contenu { get; set; }

        public List<PieceJointe> PiecesJointes { get; set; }
        //public PieceJointe PieceJointe { get; set; } dans le cas de 0 à 1 pièce jointe
    }
}
