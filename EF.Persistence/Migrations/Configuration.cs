using EF.Domain;
using System.Data.Entity.Migrations;

namespace EF.Persistence.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //Ajout de données à la création de la BD
        protected override void Seed(EFDBContext context)
        {
            //Compagnies
            context.Compagnies.AddOrUpdate(new[]
                                                {
                                                    new Compagnie { Id = 1, Nom = "Microsoft" },
                                                    new Compagnie { Id = 2, Nom = "Sony" }
                                                });

            //Adresses
            context.Adresses.AddOrUpdate(new[]
            {
                new Adresse { Id = 1, Rue = "111 Sherbrooke Est", Ville = "Montréal", Province = "Québec", CodePostal = "H123K3", TelephoneInterne = "5141112222", TelephonePublic = "5143334444" },
                new Adresse { Id = 2, Rue = "222 St-Catherine", Ville = "Montréal", Province = "Québec", CodePostal = "H5G3E4", TelephoneInterne = "5145556666", TelephonePublic = "5147778888" }
            });

            //Postes
            context.Postes.AddOrUpdate(new[]
            {
                new Poste { Id = 1, Nom =  "Programmeur"},
                new Poste { Id = 2, Nom =  "Gestionnaire"}
            });

            //Employés
            context.Employes.AddOrUpdate(new[] { new Employe { Id = 1, Nom = "Daniel", Prenom = "Beaulieu", AdresseId = 1, CompagnieId = 1, PosteId = 1 } });
            context.Employes.AddOrUpdate(new[] { new Employe { Id = 2, Nom = "Eric", Prenom = "Lambert", AdresseId = 2, CompagnieId = 1, PosteId = 2} });
        }
    }
}
