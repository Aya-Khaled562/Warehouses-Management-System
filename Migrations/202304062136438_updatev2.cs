namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatev2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitsOfMeasure", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "UnitsOfMeasure");
        }
    }
}
