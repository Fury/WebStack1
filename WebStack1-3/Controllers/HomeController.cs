using System.Web.Mvc;
using WebStack1_3.Models;

namespace WebStack1_3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PizzaAanmaken()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PizzaAanmaken(Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return View(pizza);
            }
            return RedirectToAction("ShowPizza", pizza);
        }

        public ActionResult ShowPizza(Pizza pizza)
        {
            return View(pizza);
        }

    }
}
