using FineAPI.Entities;
using FineAPI.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Repositories
{
    public class FineRepository : RepositoryBase<Fine>, IFineRepository
    {
        public FineRepository(FineContext context) : base(context)
        {}

        public override async Task<IEnumerable<Fine>> GetAll()
        {
            return await _context.Fines
                .Include(f => f.TypeFine)
                .ToListAsync();
        }

        public override async Task<Fine> GetAsync(int id)
        {
            return await _context.Fines.Where(f => f.Id == id)
                .Include(f => f.TypeFine)
                .FirstAsync();
        }

        public async Task<IEnumerable<Fine>> GetFineByPersonId(int id)
        {
            return await _context.Set<Fine>().Where(c => c.PersonId == id).ToListAsync();
        }
        public async Task<IEnumerable<Fine>> GetFineByAvtoId(int id)
        {
            return await _context.Set<Fine>().Where(c => c.AvtoId == id).ToListAsync();
        }
    }
}
