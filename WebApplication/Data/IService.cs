using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Data.Model;

namespace WebApplication.Data {
    public interface IService 
    {
        Task <IList<Adult>> GetAsync();
    }
}