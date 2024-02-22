using TaskMaster.Core.Entities;

namespace TaskMaster.Infrastructure.IRepository
{
    public interface IUserRepo
    {
        public UserResponse LoginResource(string Username, string Password);
        public int RegisterResource(string Username, string Email, string Password);
        public User UserResource(int Id, string Username, string Email);
    }
}
