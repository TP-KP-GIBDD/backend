using Hijacking.Entities;
using Hijacking.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Services
{
    public class ProtocolService : IProtocolService
    {
        private readonly IProtocolService _protocolService;

        public async Task<Protocol> Create(Protocol responce)
        {
            return await _protocolService.Create(responce);
        }

        public async Task Delete(int id)
        {
            await _protocolService.Delete(id);
        }

        public async Task<IEnumerable<Protocol>> GetAll()
        {
            return await _protocolService.GetAll();
        }

        public async Task<Protocol> GetProtocolId(int id)
        {
            return await _protocolService.GetProtocolId(id);
        }

        public async Task<Protocol> Update(Protocol responce)
        {
            return await _protocolService.Update(responce);
        }
    }
}
