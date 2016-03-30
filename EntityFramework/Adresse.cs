using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Domain
{
    public class Adresse
    {
        public int Id { get; set; }
        public string Rue { get; set; }
        public string ComplementAdresse { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
        public string CodePostal { get; set; }
        public string TelephoneInterne { get; set; }
        public string TelephonePublic { get; set; }
    }
}
