using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServerApp.Data.AuthData;

namespace WebServerApp.Services
{
    interface IUserService
    {
        public bool ValidateUser(string username, string password);
    }
}
