using System.Linq;
using WebServerApp.Data.AuthData;
using WebServerApp.Database;

namespace WebServerApp.Services
{
    public class UserService : IUserService
    {
        public bool ValidateUser(string username, string password)
        {
            User user;
            using (var context = new UserDbContext())
            {
                user = context.Users.SingleOrDefault(a => a.Username == username);
            }
            return user != null && user.Password.Equals(password);
        }
    }
}
