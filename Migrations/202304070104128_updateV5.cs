namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateV5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stores", "ResponsiblePerson_ID", "dbo.Employees");
            DropIndex("dbo.Stores", new[] { "ResponsiblePerson_ID" });
            RenameColumn(table: "dbo.Stores", name: "ResponsiblePerson_ID", newName: "EmployeeId");
            AlterColumn("dbo.Stores", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Stores", "EmployeeId");
            AddForeignKey("dbo.Stores", "EmployeeId", "dbo.Employees", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stores", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Stores", new[] { "EmployeeId" });
            AlterColumn("dbo.Stores", "EmployeeId", c => c.Int());
            RenameColumn(table: "dbo.Stores", name: "EmployeeId", newName: "ResponsiblePerson_ID");
            CreateIndex("dbo.Stores", "ResponsiblePerson_ID");
            AddForeignKey("dbo.Stores", "ResponsiblePerson_ID", "dbo.Employees", "ID");
        }
    }
}
