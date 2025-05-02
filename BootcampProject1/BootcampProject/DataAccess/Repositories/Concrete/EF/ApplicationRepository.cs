using DataAccess.Repositories.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete.EF
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly DbContext _context;

        public ApplicationRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<Application>> GetAllAsync()
        {
            return await _context.Set<Application>().ToListAsync();
        }

        public async Task<Application> GetByIdAsync(int id)
        {
            return await _context.Set<Application>().FindAsync(id);
        }

        public async Task AddAsync(Application application)
        {
            await _context.Set<Application>().AddAsync(application);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Application application)
        {
            _context.Set<Application>().Update(application);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Application application)
        {
            _context.Set<Application>().Remove(application);
            await _context.SaveChangesAsync();
        }
    }
}
