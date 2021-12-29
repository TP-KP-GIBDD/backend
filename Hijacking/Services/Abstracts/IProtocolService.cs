using Hijacking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Services.Abstracts
{
    public interface IProtocolService
    {
        Task<Protocol> GetProtocolId(int id);
        Task<IEnumerable<Protocol>> GetAll();
        Task<Protocol> Create(Protocol responce);
        Task<Protocol> Update(Protocol responce);
        Task Delete(int id);
    }
}
