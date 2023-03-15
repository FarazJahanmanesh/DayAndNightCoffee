using DayAndNightCoffee.Core.Domain.Contracts;
using DayAndNightCoffee.Core.Domain.Dto.UserDetailDto.Repository;
using DayAndNightCoffee.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAndNightCoffee.Infra.Database.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DayAndNightCoffeeDbContext _context;
        public UserRepository(DayAndNightCoffeeDbContext context)
        {
            _context = context;
        }
        public void CreateUser(CreateUserDetailDto User)
        {
            _context.Users.Add(new User
            {
                Name=User.UserName,
                Password=User.Password,
                phone=User.Phone,
            });
            _context.SaveChanges();
        }

        public void LoginUser()
        {
            throw new NotImplementedException();
        }
    }
}
