using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServerApp.Data.AuthData;
using WebServerApp.Services;

namespace WebServerApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        IUserService userService;

        public UsersController()
        {
            userService = new UserService();
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;

            try
            {
                if (userService.validateUser(user)) return user;
                else return null;
            }

            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
                return null;
            }
        }
    }
}
