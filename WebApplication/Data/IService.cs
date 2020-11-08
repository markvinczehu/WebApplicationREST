using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Data.Model;

namespace WebApplication.Data {
    public interface IService {
        Task <IList<Adult>> GetAsync();
        Task   AddAsync(Adult adult);
        Task   RemoveAsync(int Id);
        Task   UpdateAsync(Adult adult);
    }
}