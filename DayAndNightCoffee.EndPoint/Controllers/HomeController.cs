using Microsoft.AspNetCore.Mvc;

namespace DayAndNightCoffee.EndPoint.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}