using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public List<Product>? Products { get; set; }
    }
}
