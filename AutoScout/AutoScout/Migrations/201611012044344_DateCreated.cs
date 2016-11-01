namespace AutoScout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "DateCreated");
        }
    }
}
