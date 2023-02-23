using DayAndNightCoffee.Core.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DayAndNightCoffee.EndPoint.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryProductServices _categoryProductServices;
        public HomeController(ICategoryProductServices categoryProductServices)
        {
            _categoryProductServices = categoryProductServices;
        }
        public IActionResult Index()
        {
            var AllCategoryProduct=_categoryProductServices.ShowAllCategoryProduct();
            return View(AllCategoryProduct);
        }
    }
}