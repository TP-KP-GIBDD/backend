using AvtoAPI.Entities;
using AvtoAPI.Models;
using AvtoAPI.Repositories;
using AvtoAPI.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services
{
    public class RudderService : IRudderService
    {
        private readonly IRudderRepository _rudderRepository;

        public RudderService(IRudderRepository rudderRepository)
        {
            _rudderRepository = rudderRepository;
        }

        public async Task<Rudder> Create(Rudder rudder)
        {
            return await _rudderRepository.Create(rudder);
        }

        public async Task DeleteRudder(int id)
        {
            await _rudderRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Rudder>> GetAll()
        {
            return await _rudderRepository.GetAll();
        }

        public async Task<Rudder> GetRudderById(int id)
        {
            return await _rudderRepository.GetAsync(id);
        }

        public async Task<Rudder> UpdateRudder(Rudder rudder)
        {
            return await _rudderRepository.UpdateAsync(rudder);
        }
    }
}
