using Blog.Models;

namespace Blog.DAO
{
    public class UserDao : Dao
    {
        public User Add(User user)
        {
            var newUser = dbContext.Users.Add(user).Entity;
            dbContext.SaveChanges();
            return newUser;
        }

        public List<User> GetAll()
        {
            return dbContext.Users.ToList();
        }
    }
}
