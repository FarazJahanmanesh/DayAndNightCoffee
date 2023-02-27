using DayAndNightCoffee.Core.Domain.Contracts;
using DayAndNightCoffee.Core.Domain.Dto.ProductDetailDto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Application.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository=productRepository;
        }
        public List<ShowsAllProductDetailDto> ShowsAllProduct(int id)
        {
            List<ShowsAllProductDetailDto> AllProduct = new List<ShowsAllProductDetailDto>();
            var Product = _productRepository.ShowsAllProduct(id);
            foreach (var item in Product)
            {
                AllProduct.Add(new ShowsAllProductDetailDto { Name=item.Name,Price=item.Price});
            }
            return AllProduct;
        }
    }
}
