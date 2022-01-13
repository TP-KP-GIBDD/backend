using DTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Repositories.Abstracts
{
    public interface IProtocolRepository : IBaseRepository<Protocol>
    {
        Task<IEnumerable<Protocol>> GetProtocolByIdentifier(int identifier);
        Task<IEnumerable<Protocol>> GetProtocolByInspector(int ispectorId);
        Task<IEnumerable<Protocol>> GetProtocolByAvto(int avtoId);
        Task<IEnumerable<Protocol>> GetProtocolByTypeViolation(int violation);
    }
}
