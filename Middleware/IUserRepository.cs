using ADHD.Dto.user;
using ADHD.Models;

namespace ADHD.Middleware
{
    public interface IUserRepository
    {
        User GetUserBuId(int userId);
        User SignUp(User user);
        bool Login(string email, byte[] password);
        User UpdateUser(User user);
        bool DeleteUser(int userId);
    }
}
