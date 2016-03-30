using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Domain
{
    public class Commande
    {
        public int Id { get; set; }
        public int ProduitId { get; set; }
        public Produit Produit { get; set; }
        public int CompagnieId { get; set; }
        public Compagnie Compagnie { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Numero { get; set; }
    }
}
