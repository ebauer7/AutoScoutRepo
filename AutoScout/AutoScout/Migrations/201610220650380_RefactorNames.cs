namespace AutoScout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DealershipModels", newName: "Dealerships");
            RenameTable(name: "dbo.VehicleModels", newName: "Vehicles");
            RenameTable(name: "dbo.VehicleImageModels", newName: "VehicleImages");
            RenameColumn(table: "dbo.VehicleImages", name: "VehicleModelId", newName: "VehicleId");
            RenameColumn(table: "dbo.Vehicles", name: "DealershipModelId", newName: "DealershipId");
            RenameIndex(table: "dbo.VehicleImages", name: "IX_VehicleModelId", newName: "IX_VehicleId");
            RenameIndex(table: "dbo.Vehicles", name: "IX_DealershipModelId", newName: "IX_DealershipId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Vehicles", name: "IX_DealershipId", newName: "IX_DealershipModelId");
            RenameIndex(table: "dbo.VehicleImages", name: "IX_VehicleId", newName: "IX_VehicleModelId");
            RenameColumn(table: "dbo.Vehicles", name: "DealershipId", newName: "DealershipModelId");
            RenameColumn(table: "dbo.VehicleImages", name: "VehicleId", newName: "VehicleModelId");
            RenameTable(name: "dbo.VehicleImages", newName: "VehicleImageModels");
            RenameTable(name: "dbo.Vehicles", newName: "VehicleModels");
            RenameTable(name: "dbo.Dealerships", newName: "DealershipModels");
        }
    }
}
