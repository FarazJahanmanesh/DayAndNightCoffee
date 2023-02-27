using DayAndNightCoffee.Core.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DayAndNightCoffee.EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public IActionResult ShowsAllProduct(int id)
        {
            var AllProduct = _productServices.ShowsAllProduct(id);
            return View(AllProduct);
        }
    }
}
