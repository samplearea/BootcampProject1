using DataAccess.Repositories.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete.EF
{
    public class BootcampRepository : IBootcampRepository
    {
        private readonly DbContext _context;

        public BootcampRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<Bootcamp>> GetAllAsync()
        {
            return await _context.Set<Bootcamp>().ToListAsync();
        }

        public async Task<Bootcamp> GetByIdAsync(int id)
        {
            return await _context.Set<Bootcamp>().FindAsync(id);
        }

        public async Task AddAsync(Bootcamp bootcamp)
        {
            await _context.Set<Bootcamp>().AddAsync(bootcamp);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Bootcamp bootcamp)
        {
            _context.Set<Bootcamp>().Update(bootcamp);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Bootcamp bootcamp)
        {
            _context.Set<Bootcamp>().Remove(bootcamp);
            await _context.SaveChangesAsync();
        }
    }
}
