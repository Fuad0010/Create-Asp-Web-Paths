using Microsoft.AspNetCore.Mvc;

namespace firtstAspApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content($"Home controller Index action worked {id} ");
            return View();
        }
        public IActionResult About()
        {
            //return Content($"Home controller About action worked {id} ");
            return View();
        }
    }
}
