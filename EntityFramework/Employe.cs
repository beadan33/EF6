using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Domain
{
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int AdresseId { get; set; }
        public Adresse Adresse { get; set; }
        public int CompagnieId { get; set; }
        public Compagnie Compagnie { get; set; }
        public int PosteId { get; set; }
        public Poste Poste { get; set; }
    }
}
