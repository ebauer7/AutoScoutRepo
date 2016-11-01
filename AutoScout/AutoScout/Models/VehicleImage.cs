using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoScout.Models
{
    public class VehicleImage
    {
        public int Id { get; set; }
        public byte[] ImageBytes { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int VehicleId { get; set; }
    }
}