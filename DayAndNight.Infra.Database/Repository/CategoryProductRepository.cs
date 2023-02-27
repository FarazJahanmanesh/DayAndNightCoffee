using DayAndNightCoffee.Core.Domain.Contracts;
using DayAndNightCoffee.Core.Domain.Dto.CategoryProductDetailDto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Infra.Database.Repository
{
    public class CategoryProductRepository: ICategoryProductRepository
    {
        private readonly DayAndNightCoffeeDbContext _dayAndNightCoffeeDbContext;
        public CategoryProductRepository(DayAndNightCoffeeDbContext dayAndNightCoffeeDbContext)
        {
            _dayAndNightCoffeeDbContext = dayAndNightCoffeeDbContext;
        }
        public List<ShowAllCategoryProductDetailDto> ShowALlCategoryProduct()
        {
            List<ShowAllCategoryProductDetailDto> AllCategoryProduct= new List<ShowAllCategoryProductDetailDto>();
            var CategoryProduct=_dayAndNightCoffeeDbContext.CategoryProducts.ToList();
            foreach(var item in CategoryProduct)
            {
                AllCategoryProduct.Add(new ShowAllCategoryProductDetailDto {  Id=item.Id,Name = item.Name ,PhotoName=item.PhotoName});
            }
            return AllCategoryProduct;
        }
    }
}
