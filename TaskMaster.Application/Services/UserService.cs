using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Application.Contract;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Application.Services
{
    public class UserService(IUserRepository userRepo) : IUserService
    {
        private readonly IUserRepository _userRepo = userRepo;
        public UserResponse LoginResource(string Username, string Password)
        {
            return _userRepo.LoginResource(Username, Password);
        }

        public int RegisterResource(string Username, string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public User UserResource(int Id, string Username, string Email)
        {
            throw new NotImplementedException();
        }
    }
}
