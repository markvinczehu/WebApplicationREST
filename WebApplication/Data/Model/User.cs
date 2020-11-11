namespace WebApplication.Data.Model
{
    public class User
    {
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        private string password;
        private string username;
    }
}