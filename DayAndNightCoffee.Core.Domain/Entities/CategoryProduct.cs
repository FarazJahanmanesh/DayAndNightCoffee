﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Entities
{
    public class CategoryProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoName { get; set; }
        public List<Product> Products { get; set; }
    }
}
