﻿namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateV61 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transfers", "TransferNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transfers", "TransferNumber");
        }
    }
}
