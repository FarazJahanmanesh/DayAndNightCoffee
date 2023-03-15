using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int phone { get; set; }
        public string Password { get; set; }
        public Cart cart { get; set; }
        public DateTime Created { get; set; }= DateTime.Now;
    }
}
