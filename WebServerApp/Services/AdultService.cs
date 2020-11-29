using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebServerApp.Data.Model;
using WebServerApp.Database;

namespace WebServerApp.Services
{
    public class AdultService : IAdultService
    {
        public IList<Adult> GetAllAdults()
        {
            List<Adult> adult;
            using (var context = new UserDbContext())
            {
                adult = context.Adults.ToList();
            }
            return adult;
        }
    }
}
