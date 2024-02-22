using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Application.Contract;
using TaskMaster.Core.Entities;

namespace TaskMaster.Application.Services
{
    public class UserService : IUser
    {
        public UserResponse LoginResource(string Username, string Password)
        {
            throw new NotImplementedException();
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
