using WebServerApp.Data.AuthData;

namespace WebServerApp.Services
{
    public class UserService : IUserService
    {
        public bool validateUser(User user)
        {
            if (user.Username == "asdfgh" && user.Password == "qwertz") return true;
            else return false;
        }
    }
}
