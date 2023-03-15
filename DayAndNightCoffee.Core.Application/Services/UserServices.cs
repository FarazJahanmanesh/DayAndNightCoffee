using DayAndNightCoffee.Core.Domain.Contracts;
using DayAndNightCoffee.Core.Domain.Dto.UserDetailDto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Core.Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _repository;
        public UserServices(IUserRepository repository)
        {
            _repository=repository;
        }
        public void CreateUser(CreateUserDetailDto user)
        {
            _repository.CreateUser(new Domain.Dto.UserDetailDto.Repository.CreateUserDetailDto 
            {
                UserName=user.UserName,
                Password=user.Password,
                Phone=user.Phone
            });
        }

        public void LoginUser()
        {
            _repository.LoginUser();
        }
    }
}
