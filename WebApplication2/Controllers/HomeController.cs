using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Timebanking()
        {

            return View();
        }


        public ActionResult Offers()
        {       
            return View();
        }

        public ActionResult Requests()
        {         
            return View();
        }

        public ActionResult News()
        {
            return View();
        }
    }
}