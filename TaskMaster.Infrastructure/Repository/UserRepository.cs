using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskMaster.Core.Entities;
using TaskMaster.Infrastructure.Extension;
using TaskMaster.Infrastructure.IRepository;

namespace TaskMaster.Infrastructure.Repository
{
    public class UserRepository : IUserRepo
    {
        private readonly string _pepper;
        private readonly int _iteration = 3;
        public UserRepository()
        {
            _pepper = Environment.GetEnvironmentVariable("PasswordHashExamplePepper")!;
        }
        public UserResponse LoginResource(string Username, string Password)
        {
            var user = new User();

            if (user == null)
                throw new Exception("Username or password did not match.");

            var passwordHash = PasswordHasher.ComputeHash(Password, user.PasswordSalt, _pepper, _iteration);
            if (user.PasswordHash != passwordHash)
                throw new Exception("Username or password did not match.");

            return new UserResponse();
        }

        public int RegisterResource(string Username, string Email, string Password)
        {
            var user = new User
            {
                Username = Username,
                Email = Email,
                PasswordSalt = PasswordHasher.GenerateSalt()
            };
            user.PasswordHash = PasswordHasher.ComputeHash(Password, user.PasswordSalt, _pepper, _iteration);
            return 1;

        }

        public User UserResource(int Id, string Username, string Email)
        {
            throw new NotImplementedException();
        }
    }
}
