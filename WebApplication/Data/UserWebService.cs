using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApplication.Data.Model;

namespace WebApplication.Data
{
    public class UserWebService : IUserService
    {
        public async Task<User> ValidateLogin(string username, string password)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://localhost:5003/users?username={username}&password={password}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                User resultUser = JsonConvert.DeserializeObject<User>(userAsJson);
                return resultUser;
            } 
            throw new Exception("User not found");
        }
    }
}