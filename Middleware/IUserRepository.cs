using ADHD.Dto.user;
using ADHD.Models;

namespace ADHD.Middleware
{
    public interface IUserRepository
    {
        Task<User> GetUserBuId(int userId);
        Task<User> SignUp(User user);
        bool Login(string email, string password);
        Task<User> UpdateUser(User user);
        bool DeleteUser(int userId);
    }
}
