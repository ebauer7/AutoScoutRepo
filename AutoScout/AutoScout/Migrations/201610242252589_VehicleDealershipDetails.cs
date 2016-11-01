namespace AutoScout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VehicleDealershipDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dealerships", "FaxNumber", c => c.String());
            AddColumn("dbo.Dealerships", "Notes", c => c.String());
            AddColumn("dbo.Vehicles", "Condition", c => c.String());
            AddColumn("dbo.Vehicles", "CylinderNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "TransmissionType", c => c.String());
            DropColumn("dbo.Dealerships", "DealershipLicenseNumber");
            DropColumn("dbo.Dealerships", "Certified");
            DropColumn("dbo.Vehicles", "StockNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "StockNumber", c => c.String());
            AddColumn("dbo.Dealerships", "Certified", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dealerships", "DealershipLicenseNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Vehicles", "TransmissionType");
            DropColumn("dbo.Vehicles", "CylinderNumber");
            DropColumn("dbo.Vehicles", "Condition");
            DropColumn("dbo.Dealerships", "Notes");
            DropColumn("dbo.Dealerships", "FaxNumber");
        }
    }
}
