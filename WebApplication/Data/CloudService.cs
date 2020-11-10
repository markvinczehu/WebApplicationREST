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
            uri = "http://dnp.metamate.me/Adults";
        }

        public async Task<IList<Adult>> GetAsync() {
            /*Task<string> stringAsync = client.GetStringAsync(uri);
            string message = await stringAsync;*/
            Adult adult = new Adult();
            string message = await client.GetStringAsync(uri);
            System.Diagnostics.Debug.WriteLine(message);
            IList<Adult> list = JsonConvert.DeserializeObject <List<Adult>>(message);
            foreach (Adult item in list)
            {
                System.Diagnostics.Debug.WriteLine(item);
            }
            return list;
        }
        
        public async Task AddAsync(Adult adult) {
            string AsJson = System.Text.Json.JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(AsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri+"/Adults", content);
        }

        public async Task RemoveAsync(int Id) {
            await client.DeleteAsync($"{uri}/Adults/{Id}");
        }

        public async Task UpdateAsync(Adult adult) {
            string AsJson = System.Text.Json.JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(AsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{uri}/Adults/{adult.Id}", content);
        }
    }
}