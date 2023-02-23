using DayAndNightCoffee.Core.Domain.Contracts;
using DayAndNightCoffee.Core.Domain.Dto.ProductDetailDto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Infra.Database.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly DayAndNightCoffeeDbContext _DayAndNightCoffeeDbContext;
        public ProductRepository(DayAndNightCoffeeDbContext dayAndNightCoffeeDbContext)
        {
            _DayAndNightCoffeeDbContext=dayAndNightCoffeeDbContext;
        }
        public List<ShowsAllProductDetailDto> ShowsAllProduct()
        {
            List<ShowsAllProductDetailDto> AllProduct = new List<ShowsAllProductDetailDto> ();
            var product=_DayAndNightCoffeeDbContext.Products.ToList();
            foreach (var item in product)
            {
                AllProduct.Add(new ShowsAllProductDetailDto {Name=item.Name , Price=item.Price});
            }
            return AllProduct;
        }
    }
}
