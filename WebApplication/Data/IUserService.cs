using System.Threading.Tasks;
using WebApplication.Data.Model;

namespace WebApplication.Data
{
    public interface IUserService
    {
        Task<User> ValidateLogin(string username, string password);
    }
}