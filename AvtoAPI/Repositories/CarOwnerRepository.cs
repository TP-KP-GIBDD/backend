using AvtoAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public class CarOwnerRepository : RepositoryBase<CarOwner>, ICarOwnerRepository
    {
        public CarOwnerRepository(AvtoContext context) : base(context) 
        {}
        public virtual async Task<IEnumerable<CarOwner>> GetCarOwnerByAvtoId(int id)
        {
            return await _context.Set<CarOwner>().Where(c => c.AvtoId == id).ToListAsync();
        }
    }
}
