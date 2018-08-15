using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceEmail
{
    public class PieceJointe
    {
        public Email Email { get; set; }
        public DateTime DateAjout { get; set; }
        public FileInfo Fichier { get; set; }
    }
}
