using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleLinq
{
    public class ville
    {
        public string Nom { get; set; }
        public string CodePostal { get; set; }
        public string CodeInsee { get; set; }

        public string Departement
        {
            get { return this.CodePostal.Substring(0, 2); }
        }
    }
}
