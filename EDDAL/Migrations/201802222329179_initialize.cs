namespace EDDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Zip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        getTime = c.DateTime(nullable: false),
                        CurrentTime = c.DateTime(nullable: false),
                        CurrrentLocation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNum = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weight = c.Double(nullable: false),
                        Status = c.Int(),
                        RecevierName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sortings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaId = c.Int(nullable: false),
                        ParcelId = c.Int(nullable: false),
                        EntryTime = c.DateTime(nullable: false),
                        OutTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.Parcels", t => t.ParcelId, cascadeDelete: true)
                .Index(t => t.AreaId)
                .Index(t => t.ParcelId);
            
            CreateTable(
                "dbo.Trackings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParcelId = c.Int(nullable: false),
                        DeliveryId = c.Int(nullable: false),
                        CompleteTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deliveries", t => t.DeliveryId, cascadeDelete: true)
                .ForeignKey("dbo.Parcels", t => t.ParcelId, cascadeDelete: true)
                .Index(t => t.ParcelId)
                .Index(t => t.DeliveryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trackings", "ParcelId", "dbo.Parcels");
            DropForeignKey("dbo.Trackings", "DeliveryId", "dbo.Deliveries");
            DropForeignKey("dbo.Sortings", "ParcelId", "dbo.Parcels");
            DropForeignKey("dbo.Sortings", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.Deliveries", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Trackings", new[] { "DeliveryId" });
            DropIndex("dbo.Trackings", new[] { "ParcelId" });
            DropIndex("dbo.Sortings", new[] { "ParcelId" });
            DropIndex("dbo.Sortings", new[] { "AreaId" });
            DropIndex("dbo.Deliveries", new[] { "EmployeeId" });
            DropTable("dbo.Trackings");
            DropTable("dbo.Sortings");
            DropTable("dbo.Parcels");
            DropTable("dbo.Employees");
            DropTable("dbo.Deliveries");
            DropTable("dbo.Areas");
        }
    }
}
