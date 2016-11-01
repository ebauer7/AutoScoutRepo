namespace AutoScout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DealershipPhoneNumberString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dealerships", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dealerships", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
