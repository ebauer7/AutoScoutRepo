namespace AutoScout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VinStringPlusDefaultImage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VehicleImages", "VehicleId", "dbo.Vehicles");
            AddColumn("dbo.Dealerships", "ProfileBackgroundImage", c => c.Binary());
            AddColumn("dbo.VehicleImages", "Vehicle_Id", c => c.Int());
            AddColumn("dbo.Vehicles", "DefaultImage_Id", c => c.Int());
            AlterColumn("dbo.Vehicles", "VIN", c => c.String());
            CreateIndex("dbo.VehicleImages", "Vehicle_Id");
            CreateIndex("dbo.Vehicles", "DefaultImage_Id");
            AddForeignKey("dbo.Vehicles", "DefaultImage_Id", "dbo.VehicleImages", "Id");
            AddForeignKey("dbo.VehicleImages", "Vehicle_Id", "dbo.Vehicles", "Id");
            DropColumn("dbo.Dealerships", "BackgroundGraphic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dealerships", "BackgroundGraphic", c => c.Binary());
            DropForeignKey("dbo.VehicleImages", "Vehicle_Id", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "DefaultImage_Id", "dbo.VehicleImages");
            DropIndex("dbo.Vehicles", new[] { "DefaultImage_Id" });
            DropIndex("dbo.VehicleImages", new[] { "Vehicle_Id" });
            AlterColumn("dbo.Vehicles", "VIN", c => c.Int(nullable: false));
            DropColumn("dbo.Vehicles", "DefaultImage_Id");
            DropColumn("dbo.VehicleImages", "Vehicle_Id");
            DropColumn("dbo.Dealerships", "ProfileBackgroundImage");
            AddForeignKey("dbo.VehicleImages", "VehicleId", "dbo.Vehicles", "Id", cascadeDelete: true);
        }
    }
}
