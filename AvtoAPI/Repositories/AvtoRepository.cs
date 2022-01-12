using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvtoAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvtoAPI.Repositories
{
    public class AvtoRepository : RepositoryBase<Avto>, IAvtoRepository
    {
        public AvtoRepository(AvtoContext context): base(context)
        {}
        public virtual async Task<Avto> GetByNumberAvto(string numberAvto)
        {
            return await _context.Set<Avto>().FindAsync(numberAvto);
        }

        public override async Task<IEnumerable<Avto>> GetAll()
        {
            return await _context.Avtos
                .Include(rs => rs.BodyType)
                .Include(rs => rs.BrandModel)
                    .ThenInclude(rs => rs.Brand)
                .Include(rs => rs.Color)
                .Include(rs => rs.Rudder)
                .ToListAsync();
        }

        public override async Task<Avto> GetAsync(int id)
        {
            return await _context.Avtos
                .Where(rs => rs.Id == id)
                .Include(rs => rs.BodyType)
                .Include(rs => rs.BrandModel)
                    .ThenInclude(b => b.Brand)
                .Include(rs => rs.Color)
                .Include(rs => rs.Rudder)
                .FirstAsync();
        }
    }
}
