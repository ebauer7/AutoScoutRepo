using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoScout.Models
{
    public class DealershipManager
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Notes { get; set; }
    }

}