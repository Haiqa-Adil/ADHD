using ADHD.Data;
using ADHD.Dto.user;
using ADHD.Middleware;
using ADHD.Models;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository
{
    public class UserRepository : IUserRepository
    {
        private DataContext db;
        public UserRepository(DataContext db)
        {
            this.db = db;
        }

        public bool DeleteUser(int userId)
        {
            var user = db.Users.
                Where(user => user.Id == userId && user.IsDeleted == 0).
                FirstOrDefault();

            if (user == null)
            {
                return false;
            }

            user.IsDeleted = 1;
            db.SaveChanges();

            return true;
        }

        public async Task<User> GetUserBuId(int userId)
        {
            var user = await db.Users.
                Where(user => user.Id == userId).
                FirstOrDefaultAsync();

            return user;
        }

        public bool Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        /*        public bool Login(string email , string password)
                {   
                    var user = db.Users.
                                    Where(x => x.Email == email && x.Password == password).
                                    FirstOrDefault();
                    if(user == null)
                        return false;

                    return true;
                }
        */
        public async Task<User> SignUp(User user)
        {
            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            await db.SaveChangesAsync();

            return user;
        }

    }
}
