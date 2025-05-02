using DataAccess.Repositories.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete.EF
{
    public class BlacklistRepository : IBlacklistRepository
    {
        private readonly DbContext _context;

        public BlacklistRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<Blacklist>> GetAllAsync()
        {
            return await _context.Set<Blacklist>().ToListAsync();
        }

        public async Task<Blacklist> GetByIdAsync(int id)
        {
            return await _context.Set<Blacklist>().FindAsync(id);
        }

        public async Task AddAsync(Blacklist blacklist)
        {
            await _context.Set<Blacklist>().AddAsync(blacklist);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Blacklist blacklist)
        {
            _context.Set<Blacklist>().Update(blacklist);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Blacklist blacklist)
        {
            _context.Set<Blacklist>().Remove(blacklist);
            await _context.SaveChangesAsync();
        }
    }
}
