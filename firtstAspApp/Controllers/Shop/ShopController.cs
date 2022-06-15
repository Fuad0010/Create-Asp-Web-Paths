using Microsoft.AspNetCore.Mvc;

namespace firtstAspApp.Controllers.Shop
{
    public class ShopController : Controller
    {
        public IActionResult Cars()
        {
            //return Content ($"Shop controller Cars action worked {id}");
            return View();
        }
        public IActionResult Trucks(int id)
        {
            //return Content ($"Shop controller Trucks action worked {id}");
            return View();
        }
    }
}
