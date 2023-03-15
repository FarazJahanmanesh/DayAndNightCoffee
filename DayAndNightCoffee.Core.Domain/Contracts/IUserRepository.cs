using DayAndNightCoffee.Core.Domain.Dto.UserDetailDto.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Domain.Contracts
{
    public interface IUserRepository
    {
        public void CreateUser(CreateUserDetailDto User);
        public void LoginUser();
    }
}
