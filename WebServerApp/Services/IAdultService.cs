using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Model;

namespace WebServerApp.Services
{
    interface IAdultService
    {
        public IList<Adult> GetAllAdults();
    }
}
