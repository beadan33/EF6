using System.Data.Entity;
using EF.Domain;

namespace EF.Persistence
{
    public class EFDBContext : DbContext
    {
        public EFDBContext() : base("name=EF6ConnectionString") { }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Compagnie> Compagnies { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Poste> Postes { get; set; }
    }
}
