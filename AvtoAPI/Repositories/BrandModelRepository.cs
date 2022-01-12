using AvtoAPI.Entities;
using AvtoAPI.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public class BrandModelRepository : RepositoryBase<BrandModel>, IBrandModelRepository
    {
        public BrandModelRepository(AvtoContext context) : base(context)
        { }
        public virtual async Task<IEnumerable<BrandModel>> GetBrandModelByBrandId(int id)
        {
            return await _context.Set<BrandModel>().Where(x => x.BrandId == id).ToListAsync();
        }
    }
}
