using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServerApp.Data.AuthData
{
    public class User
    {
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        private string password;
        private string username;
    }
}
