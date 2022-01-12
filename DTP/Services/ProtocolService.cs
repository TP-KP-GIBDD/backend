using DTP.Entities;
using DTP.Repositories.Abstracts;
using DTP.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services
{
    public class ProtocolService : IProtocolService
    {
        private readonly IProtocolService _protocolService;
        private readonly IProtocolRepository _protocolRepository;

        public async Task<Protocol> Create(Protocol protocol)
        {
            return await _protocolService.Create(protocol);
        }

        public async Task Delete(int Id)
        {
            await _protocolService.Delete(Id);
        }

        public async Task<IEnumerable<Protocol>> GetAll()
        {
            return await _protocolService.GetAll();
        }

        public async Task<Protocol> GetProtocolByIdentifier(int identifier)
        {
            return await _protocolRepository.GetProtocolByIdentifier(identifier);
        }

        public async Task<Protocol> GetProtocolByInspector(string inspector)
        {
            return await _protocolRepository.GetProtocolByInspector(inspector);
        }

        public async Task<Protocol> GetProtocolByTypeViolation(int violation)
        {
            return await _protocolRepository.GetProtocolByTypeViolation(violation);
        }

        public async Task<Protocol> GetProtocolById(int Id)
        {
            return await _protocolService.GetProtocolById(Id);
        }

        public async Task<Protocol> Update(Protocol protocol)
        {
            return await _protocolService.Update(protocol);
        }
    }
}
