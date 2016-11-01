using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AutoScout.Models
{
    public class Dealership
    {
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }

        public string Notes { get; set; }

        public bool Active { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public byte[] Icon { get; set; }

        public byte[] ProfileBackgroundImage { get; set; }

        public ICollection<Vehicle> Vehicles;

        public virtual AutoScoutIdentityUser AutoScoutIdentityUser { get; set; }

        public string AutoScoutIdentityUserId { get; set; }

    }
}