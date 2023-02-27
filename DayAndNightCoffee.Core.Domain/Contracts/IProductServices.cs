using DayAndNightCoffee.Core.Domain.Dto.ProductDetailDto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Contracts
{
    public interface IProductServices
    {
        public List<ShowsAllProductDetailDto> ShowsAllProduct(int id);
    }
}
