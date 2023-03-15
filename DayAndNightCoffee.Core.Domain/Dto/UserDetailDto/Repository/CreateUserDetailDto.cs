using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Dto.UserDetailDto.Repository
{
    public class CreateUserDetailDto
    {
        public int Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
