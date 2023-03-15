using DayAndNightCoffee.Core.Domain.Dto.UserDetailDto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Contracts
{
    public interface IUserServices
    {
        public void CreateUser(CreateUserDetailDto user);
        public void LoginUser();
    }
}
