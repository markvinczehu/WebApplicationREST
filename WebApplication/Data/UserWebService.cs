using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
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
            System.Diagnostics.Debug.WriteLine("login_validate");
            HttpResponseMessage response = await client.GetAsync($"http://localhost:5000/users?username={username}&password={password}");
            System.Diagnostics.Debug.WriteLine(response.StatusCode + "    ," + response.Content.ReadAsStringAsync().Result);
            if (response.IsSuccessStatusCode || response.StatusCode == HttpStatusCode.OK || true)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                User user = JsonConvert.DeserializeObject<User>(json);
                return user;
            }
            else
            {
                throw new Exception("User not found");
            }
        }
    }
}