namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateV3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Store_ID", "dbo.Stores");
            DropIndex("dbo.Products", new[] { "Store_ID" });
            AlterColumn("dbo.Products", "Store_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Store_ID");
            AddForeignKey("dbo.Products", "Store_ID", "dbo.Stores", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Store_ID", "dbo.Stores");
            DropIndex("dbo.Products", new[] { "Store_ID" });
            AlterColumn("dbo.Products", "Store_ID", c => c.Int());
            CreateIndex("dbo.Products", "Store_ID");
            AddForeignKey("dbo.Products", "Store_ID", "dbo.Stores", "ID");
        }
    }
}
