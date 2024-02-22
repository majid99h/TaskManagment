using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMaster.Core.Entities;

namespace TaskMaster.Application.Contract
{
    public interface IUser
    {
        public UserResponse LoginResource(string Username, string Password);
        public  int RegisterResource(string Username, string Email, string Password);
        public  User UserResource(int Id, string Username, string Email);
    }
}
