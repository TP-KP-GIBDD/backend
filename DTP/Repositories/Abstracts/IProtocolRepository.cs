using DTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Repositories.Abstracts
{
    public interface IProtocolRepository : IBaseRepository<Protocol>
    {
        Task<Protocol> GetProtocolByIdentifier(int identifier);
        Task<Protocol> GetProtocolByInspector(string ispector);
        Task<Protocol> GetProtocolByTypeViolation(int violation);
    }
}
