using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Model;

namespace WebServerApp.Services
{
    public class AdultService : IAdultService
    {
        public IList<Adult> GetAllAdults()
        {
            System.Diagnostics.Debug.WriteLine("Service");
            IList<Adult> adults = new List<Adult>();
            string json = ReadData("adults.json");
            adults = JsonConvert.DeserializeObject<List<Adult>>(json);
            return adults;
        }
        private string ReadData(string s)
        {
            using (StreamReader jsonReader = File.OpenText(s))
            {
                string json = jsonReader.ReadToEnd();
                return json;
            }
        }
    }
}
