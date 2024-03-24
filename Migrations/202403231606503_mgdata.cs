namespace TravelAgencyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnel",
                c => new
                    {
                        PersonnelId = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prenom = c.String(nullable: false, maxLength: 50),
                        Adresse = c.String(nullable: false, maxLength: 50),
                        DateNaissance = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 10),
                        Salaire = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PersonnelId);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prenom = c.String(nullable: false, maxLength: 50),
                        NumeroTelephone = c.String(nullable: false, maxLength: 50),
                        DateNaissance = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Voyage",
                c => new
                    {
                        VoyageId = c.Int(nullable: false, identity: true),
                        Titre = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 150),
                        Destinations = c.String(nullable: false, maxLength: 60),
                        DateDepart = c.DateTime(nullable: false),
                        DateRetour = c.DateTime(nullable: false),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NombrePlacesDisponibles = c.Int(nullable: false),
                        GuideId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VoyageId)
                .ForeignKey("dbo.Guide", t => t.GuideId)
                .Index(t => t.GuideId);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        VoyageId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        DateReservation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Voyage", t => t.VoyageId, cascadeDelete: true)
                .Index(t => t.VoyageId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.ClientVoyages",
                c => new
                    {
                        Client_ClientId = c.Int(nullable: false),
                        Voyage_VoyageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Client_ClientId, t.Voyage_VoyageId })
                .ForeignKey("dbo.Client", t => t.Client_ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Voyage", t => t.Voyage_VoyageId, cascadeDelete: true)
                .Index(t => t.Client_ClientId)
                .Index(t => t.Voyage_VoyageId);
            
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        PersonnelId = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 10),
                        MotDePass = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.PersonnelId)
                .ForeignKey("dbo.Personnel", t => t.PersonnelId)
                .Index(t => t.PersonnelId);
            
            CreateTable(
                "dbo.Guide",
                c => new
                    {
                        PersonnelId = c.Int(nullable: false),
                        LanguesParlees = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonnelId)
                .ForeignKey("dbo.Personnel", t => t.PersonnelId)
                .Index(t => t.PersonnelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guide", "PersonnelId", "dbo.Personnel");
            DropForeignKey("dbo.Admin", "PersonnelId", "dbo.Personnel");
            DropForeignKey("dbo.Reservation", "VoyageId", "dbo.Voyage");
            DropForeignKey("dbo.Reservation", "ClientId", "dbo.Client");
            DropForeignKey("dbo.ClientVoyages", "Voyage_VoyageId", "dbo.Voyage");
            DropForeignKey("dbo.ClientVoyages", "Client_ClientId", "dbo.Client");
            DropForeignKey("dbo.Voyage", "GuideId", "dbo.Guide");
            DropIndex("dbo.Guide", new[] { "PersonnelId" });
            DropIndex("dbo.Admin", new[] { "PersonnelId" });
            DropIndex("dbo.ClientVoyages", new[] { "Voyage_VoyageId" });
            DropIndex("dbo.ClientVoyages", new[] { "Client_ClientId" });
            DropIndex("dbo.Reservation", new[] { "ClientId" });
            DropIndex("dbo.Reservation", new[] { "VoyageId" });
            DropIndex("dbo.Voyage", new[] { "GuideId" });
            DropTable("dbo.Guide");
            DropTable("dbo.Admin");
            DropTable("dbo.ClientVoyages");
            DropTable("dbo.Reservation");
            DropTable("dbo.Voyage");
            DropTable("dbo.Client");
            DropTable("dbo.Personnel");
        }
    }
}
