using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoScout.Models;

namespace AutoScout.Services
{
    public class ImageManagementService
    {
        private AutoScoutDBContext db;

        public ImageManagementService(AutoScoutDBContext dbContext)
        {
            db = dbContext;
        }

        public void AssignImageToVehicle(int vehicleId, HttpPostedFileBase imageFile)
        {
            try
            {
                if (imageFile != null)
                {
                    var imageBytes = new byte[imageFile.ContentLength];
                    imageFile.InputStream.Read(imageBytes, 0, imageFile.ContentLength);
                    var vehicleImage = new VehicleImage
                    {
                        VehicleId = vehicleId,
                        ImageBytes = imageBytes,
                    };

                    db.VehicleImages.Add(vehicleImage);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
                
            }
        }
    }
}