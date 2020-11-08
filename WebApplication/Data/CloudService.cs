using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Data.Model;

namespace WebApplication.Data
{
    public class CloudService : IService
    {
        private string uri = "http://dnp.metamate.me";
        private readonly HttpClient client;

        public CloudService() 
        {
            client = new HttpClient();
        }

        public async Task<IList<Adult>> GetAsync() {
            Task<string> stringAsync = client.GetStringAsync(uri+"/Adults");
            string message = await stringAsync;
            IList<Adult> result = JsonSerializer.Deserialize<IList<Adult>>(message);
            return result;
        }

        public async Task AddAsync(Adult adult) {
            string AsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(AsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri+"/Adults", content);
        }

        public async Task RemoveAsync(int Id) {
            await client.DeleteAsync($"{uri}/Adults/{Id}");
        }

        public async Task UpdateAsync(Adult adult) {
            string AsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(AsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{uri}/Adults/{adult.Id}", content);
        }
    }
}