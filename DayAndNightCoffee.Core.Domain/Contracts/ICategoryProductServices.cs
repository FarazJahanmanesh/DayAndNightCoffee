using DayAndNightCoffee.Core.Domain.Dto.CategoryProductDetailDto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Contracts
{
    public interface ICategoryProductServices
    {
        public List<ShowAllCategoryProductDetailDto> ShowAllCategoryProduct();
    }
}
