namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExchangePermitDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExchangePermitId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.ExchangePermits", t => t.ExchangePermitId)
                .Index(t => t.ExchangePermitId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ExchangePermits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PermitNumber = c.String(),
                        PermitDate = c.DateTime(nullable: false, storeType: "date"),
                        StoreId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.ImportPermits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PermitNumber = c.String(),
                        PermitDate = c.DateTime(nullable: false, storeType: "date"),
                        ProductionDate = c.DateTime(nullable: false, storeType: "date"),
                        ExpiryDate = c.DateTime(nullable: false, storeType: "date"),
                        StoreId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.ImportPermitDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImportPermitId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ImportPermits", t => t.ImportPermitId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ImportPermitId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Transfers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TransferDate = c.DateTime(nullable: false, storeType: "date"),
                        FromStoreId = c.Int(nullable: false),
                        ToStoreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stores", t => t.FromStoreId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.ToStoreId)
                .Index(t => t.FromStoreId)
                .Index(t => t.ToStoreId);
            
            CreateTable(
                "dbo.TransferItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false, storeType: "date"),
                        ExpirationDate = c.DateTime(nullable: false, storeType: "date"),
                        TransferId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Transfers", t => t.TransferId)
                .Index(t => t.TransferId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExchangePermitDetails", "ExchangePermitId", "dbo.ExchangePermits");
            DropForeignKey("dbo.ExchangePermits", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.TransferItems", "TransferId", "dbo.Transfers");
            DropForeignKey("dbo.TransferItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Transfers", "ToStoreId", "dbo.Stores");
            DropForeignKey("dbo.Transfers", "FromStoreId", "dbo.Stores");
            DropForeignKey("dbo.ImportPermits", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ImportPermits", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ImportPermitDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ExchangePermitDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ImportPermitDetails", "ImportPermitId", "dbo.ImportPermits");
            DropForeignKey("dbo.ExchangePermits", "StoreId", "dbo.Stores");
            DropIndex("dbo.TransferItems", new[] { "ProductId" });
            DropIndex("dbo.TransferItems", new[] { "TransferId" });
            DropIndex("dbo.Transfers", new[] { "ToStoreId" });
            DropIndex("dbo.Transfers", new[] { "FromStoreId" });
            DropIndex("dbo.ImportPermitDetails", new[] { "ProductId" });
            DropIndex("dbo.ImportPermitDetails", new[] { "ImportPermitId" });
            DropIndex("dbo.ImportPermits", new[] { "SupplierId" });
            DropIndex("dbo.ImportPermits", new[] { "StoreId" });
            DropIndex("dbo.ExchangePermits", new[] { "SupplierId" });
            DropIndex("dbo.ExchangePermits", new[] { "StoreId" });
            DropIndex("dbo.ExchangePermitDetails", new[] { "ProductId" });
            DropIndex("dbo.ExchangePermitDetails", new[] { "ExchangePermitId" });
            DropTable("dbo.TransferItems");
            DropTable("dbo.Transfers");
            DropTable("dbo.ImportPermitDetails");
            DropTable("dbo.ImportPermits");
            DropTable("dbo.ExchangePermits");
            DropTable("dbo.ExchangePermitDetails");
        }
    }
}
