using DayAndNightCoffee.Core.Domain.Dto.ProductDetailDto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Contracts
{
    public interface IProductRepository
    {
        public List<ShowsAllProductDetailDto> ShowsAllProduct(int id);
    }
}
