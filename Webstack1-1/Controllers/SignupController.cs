using System;
using System.Web.Mvc;

namespace Webstack1_1.Controllers
{
    public class SignupController : Controller
    {
        //
        // GET: /Signup/
        public ActionResult Index(string email = "", string emailclients = "", string passwoord = "")
        {
            if (!email.Equals("") && !emailclients.Equals("") && !passwoord.Equals(""))
            {
                ViewBag.Bericht = String.Format("Dag {0}", email);
            }
            else
            {
                ViewBag.Bericht = "";
            }
            return View();
        }
    }
}