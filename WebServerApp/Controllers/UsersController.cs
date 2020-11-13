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

        /// <summary>
        /// This method validates users from the server, enabling more actions.
        /// </summary>
        /// <param name="username">The username of the user, sent in the query.</param>
        /// <param name="password">The password of the user, sent in the query.</param>
        /// <returns>An User, embedded in a Task, with the subtype ActionResult.</returns>
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
