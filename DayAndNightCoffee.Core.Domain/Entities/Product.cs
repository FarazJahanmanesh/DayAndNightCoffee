using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ?PriceS { get; set; }
        public int ?PriceM { get; set; }
        public CategoryProduct Category { get; set; }
    }
}
