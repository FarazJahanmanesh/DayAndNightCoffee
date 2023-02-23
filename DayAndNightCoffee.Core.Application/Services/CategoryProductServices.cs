using DayAndNightCoffee.Core.Domain.Contracts;
using DayAndNightCoffee.Core.Domain.Dto.CategoryProductDetailDto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Application.Services
{
    public class CategoryProductServices:ICategoryProductServices
    {
        private readonly ICategoryProductRepository _CategoryProductRepository;
        public CategoryProductServices(ICategoryProductRepository CategoryProductRepository)
        {
            _CategoryProductRepository = CategoryProductRepository;
        }
        public List<ShowAllCategoryProductDetailDto> ShowAllCategoryProduct()
        {
            List<ShowAllCategoryProductDetailDto> AllCategoryProduct = new List<ShowAllCategoryProductDetailDto>();
            var CategoryProduct=_CategoryProductRepository.ShowALlCategoryProduct();
            foreach(var item in CategoryProduct)
            {
                AllCategoryProduct.Add(new ShowAllCategoryProductDetailDto { Name=item.Name});
            }
            return AllCategoryProduct;
        }
    }
}
