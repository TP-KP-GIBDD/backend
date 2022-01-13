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

        public virtual async Task<IEnumerable<Protocol>> GetProtocolByIdentifier(int identifier)
        {
            return await _context.Set<Protocol>().Where(a => a.identifier == identifier).ToListAsync();
        }

        public virtual async Task<IEnumerable<Protocol>> GetProtocolByInspector(int inspectorId)
        {
            return await _context.Set<Protocol>().Where(b => b.InspectorId == inspectorId).ToListAsync();
        }

        public virtual async Task<IEnumerable<Protocol>> GetProtocolByAvto(int avtoId)
        {
            return await _context.Set<Protocol>().Where(c => c.AvtoId == avtoId).ToListAsync();
        }

        public virtual async Task<IEnumerable<Protocol>> GetProtocolByTypeViolation(int violation)
        {
            return await _context.Set<Protocol>().Where(d => d.TypeViolationId == violation).ToListAsync();
        }


    }
}
