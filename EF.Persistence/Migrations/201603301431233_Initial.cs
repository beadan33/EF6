namespace EF.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rue = c.String(),
                        ComplementAdresse = c.String(),
                        Ville = c.String(),
                        Province = c.String(),
                        CodePostal = c.String(),
                        TelephoneInterne = c.String(),
                        TelephonePublic = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        AdresseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.AdresseId, cascadeDelete: true)
                .Index(t => t.AdresseId);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProduitId = c.Int(nullable: false),
                        CompagnieId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Compagnies", t => t.CompagnieId, cascadeDelete: true)
                .ForeignKey("dbo.Produits", t => t.ProduitId, cascadeDelete: true)
                .Index(t => t.ProduitId)
                .Index(t => t.CompagnieId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Compagnies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        AdresseId = c.Int(nullable: false),
                        CompagnieId = c.Int(nullable: false),
                        PosteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.AdresseId, cascadeDelete: true)
                .ForeignKey("dbo.Compagnies", t => t.CompagnieId, cascadeDelete: true)
                .ForeignKey("dbo.Postes", t => t.PosteId, cascadeDelete: true)
                .Index(t => t.AdresseId)
                .Index(t => t.CompagnieId)
                .Index(t => t.PosteId);
            
            CreateTable(
                "dbo.Postes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employes", "PosteId", "dbo.Postes");
            DropForeignKey("dbo.Employes", "CompagnieId", "dbo.Compagnies");
            DropForeignKey("dbo.Employes", "AdresseId", "dbo.Adresses");
            DropForeignKey("dbo.Commandes", "ProduitId", "dbo.Produits");
            DropForeignKey("dbo.Commandes", "CompagnieId", "dbo.Compagnies");
            DropForeignKey("dbo.Commandes", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "AdresseId", "dbo.Adresses");
            DropIndex("dbo.Employes", new[] { "PosteId" });
            DropIndex("dbo.Employes", new[] { "CompagnieId" });
            DropIndex("dbo.Employes", new[] { "AdresseId" });
            DropIndex("dbo.Commandes", new[] { "ClientId" });
            DropIndex("dbo.Commandes", new[] { "CompagnieId" });
            DropIndex("dbo.Commandes", new[] { "ProduitId" });
            DropIndex("dbo.Clients", new[] { "AdresseId" });
            DropTable("dbo.Postes");
            DropTable("dbo.Employes");
            DropTable("dbo.Produits");
            DropTable("dbo.Compagnies");
            DropTable("dbo.Commandes");
            DropTable("dbo.Clients");
            DropTable("dbo.Adresses");
        }
    }
}
