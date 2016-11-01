using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoScout.Services;
using AutoScout.Models;

namespace AutoScout.Controllers
{
    public class HomeController : Controller
    {
        private AutoScoutDBContext db = new AutoScoutDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            
            var service = new DealershipAccountService(db);
            var dealershipId = service.GetCurrentUserDealershipIdFromIdentity();
            ViewBag.Name = service.GetCurrentUserNameFromDealershipId(dealershipId);

            return View();
        }
    }
}