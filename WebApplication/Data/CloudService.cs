using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Data.Model;

namespace WebApplication.Data
{
    public class CloudService : IService
    {
        private string uri;
        private readonly HttpClient client;

        public CloudService() 
        {
            client = new HttpClient();
            uri = "http://localhost:5000";
        }

        public async Task<IList<Adult>> GetAsync() {
            System.Diagnostics.Debug.WriteLine("asdfgh");
            Task<string> task = client.GetStringAsync(uri + "/adults");
            string message = await task;
            try
            {
                IList<Adult> list = JsonConvert.DeserializeObject<List<Adult>>(message);
                return list;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
                return new List<Adult>();
            }
        }

       
    }
}