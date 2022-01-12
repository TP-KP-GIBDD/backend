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
