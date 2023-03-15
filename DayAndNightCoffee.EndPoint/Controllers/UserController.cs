using DayAndNightCoffee.Core.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DayAndNightCoffee.EndPoint.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _services;
        public UserController(IUserServices services)
        {
            _services=services;
        }
        [HttpGet]
        public IActionResult Index()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
