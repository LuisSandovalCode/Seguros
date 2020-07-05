using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seguros.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Customer()
        {
            return View();
        }

        public ActionResult CreateInsurance()
        {
            return View();
        }

        public ActionResult PolicyCustomer()
        {
            return View();
        }

        public ActionResult CustomerInsurancePolicy()
        {
            return View();
        }
    }
}