using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanBookingApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the Loan Booking Application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to contact us.";

            return View();
        }
    }
}