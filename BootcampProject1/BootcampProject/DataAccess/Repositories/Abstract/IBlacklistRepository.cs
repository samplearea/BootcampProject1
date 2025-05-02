using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IBlacklistRepository
    {
        Task<List<Blacklist>> GetAllAsync();
        Task<Blacklist> GetByIdAsync(int id);
        Task AddAsync(Blacklist blacklist);
        Task UpdateAsync(Blacklist blacklist);
        Task DeleteAsync(Blacklist blacklist);
    }
}
