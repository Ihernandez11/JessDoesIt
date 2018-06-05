using JessDoesIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JessDoesIt.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Work()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Pricing()
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
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Quote()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(Customer customer)
        {
            Customer cust = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                RequestDescription = customer.RequestDescription,
                RequestDate = DateTime.Now
            };

            db.Customers.Add(cust);
            db.SaveChanges();

            return View("Success");
        }


        public ActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Admin(LoginViewModel model, string returnUrl)
        {
            return RedirectToAction("Login", "Account");
        }

    }
}