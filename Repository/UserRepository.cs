using ADHD.Data;
using ADHD.Dto.user;
using ADHD.Middleware;
using ADHD.Models;

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

        public User GetUserBuId(int userId)
        {
            var user = db.Users.
                Where(user => user.Id == userId).
                FirstOrDefault();

            return user;
        }

        public bool Login(string email , Byte[] password)
        {   
            var user = db.Users.
                            Where(x => x.Email == email && x.PasswordHash == password).
                            FirstOrDefault();
            if(user == null)
                return false;
            
            return true;
        }

        public User SignUp(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            return user;
        }

        public User UpdateUser(User user)
        {
            db.SaveChanges();

            return user;
        }

    }
}
