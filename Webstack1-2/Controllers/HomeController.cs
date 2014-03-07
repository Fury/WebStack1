using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webstack1_2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Counter = System.Web.HttpContext.Current.Application["Counter"];
            return View();
        }

        public ActionResult PageOne(string naam = "")
        {
            if (naam.Equals(""))
            {
                return View();
            }
            else
            {
                Session["naam"] = naam;
                return RedirectToAction("PageTwo");
            }
        }

        public ActionResult PageTwo()
        {
            ViewBag.naam = Session["naam"];
            return View();
        }
    }
}
