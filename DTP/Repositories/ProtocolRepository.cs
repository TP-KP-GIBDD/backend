using DTP.Entities;
using DTP.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Repositories
{
    public class ProtocolRepository : BaseRepository<Protocol>, IProtocolRepository
    {
        public ProtocolRepository(ProtocolContext context) : base(context)
        {
        }

        public virtual async Task<Protocol> GetProtocolByIdentifier(int identifier)
        {
            return await _context.Set<Protocol>().FindAsync(identifier);
        }

        public virtual async Task<Protocol> GetProtocolByInspector(string inspector)
        {
            return await _context.Set<Protocol>().FindAsync(inspector);
        }

        public virtual async Task<Protocol> GetProtocolByTypeViolation(int violation)
        {
            return await _context.Set<Protocol>().FindAsync(violation);
        }

    }
}
