using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using DayAndNightCoffee.Core.Domain.Entities;

namespace DayAndNightCoffee.Infra.Database
{
    public class DayAndNightCoffeeDbContext:DbContext
    {
        public DayAndNightCoffeeDbContext(DbContextOptions<DayAndNightCoffeeDbContext> options) :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
