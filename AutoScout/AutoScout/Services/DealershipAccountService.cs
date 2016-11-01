using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoScout.Models;
using Microsoft.AspNet.Identity;

namespace AutoScout.Services
{
    public class DealershipAccountService
    {
        private AutoScoutDBContext db; 

        public DealershipAccountService(AutoScoutDBContext dbContext)
        {
            db = dbContext;
        }

        public void RegisterDealershipAccount(string companyName, string autoScoutIdentityUserId, string email, string city, string state, string zipCode, string phoneNumber, string faxNumber, string notes)
        {
            var db = new AutoScoutDBContext();
            var dealership = new Dealership { CompanyName = companyName, AutoScoutIdentityUserId = autoScoutIdentityUserId, Email = email, City = city, State = state, ZipCode = zipCode, PhoneNumber = phoneNumber, FaxNumber = faxNumber, Notes = notes };
            db.Dealerships.Add(dealership);
            db.SaveChanges();
        }

        public int GetCurrentUserDealershipIdFromIdentity()
        {
            var identityId = HttpContext.Current.User.Identity.GetUserId();
            var dealershipId = db.Dealerships.FirstOrDefault(x => x.AutoScoutIdentityUserId == identityId).Id;
            return dealershipId;
        }

        public string GetCurrentUserIdentity()
        {
            var identityId = HttpContext.Current.User.Identity.GetUserId();
            return identityId;
        }

        public string GetCurrentUserNameFromDealershipId(int dealershipId)
        {
            var companyName = db.Dealerships.FirstOrDefault(x => x.Id == dealershipId).CompanyName;
            return companyName;
        }
    }
}