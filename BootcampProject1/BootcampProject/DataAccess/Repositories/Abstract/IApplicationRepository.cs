using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IApplicationRepository
    {
        Task<List<Application>> GetAllAsync();
        Task<Application> GetByIdAsync(int id);
        Task AddAsync(Application application);
        Task UpdateAsync(Application application);
        Task DeleteAsync(Application application);
    }
}
