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
    public class BodyTypeService : IBodyTypeService
    {
        private readonly IBodyTypeRepository _bodyTypeRepository;

        public BodyTypeService(IBodyTypeRepository bodyTypeRepository)
        {
            _bodyTypeRepository = bodyTypeRepository;
        }

        public async Task<BodyType> Create(BodyType bodyType)
        {
            return await _bodyTypeRepository.Create(bodyType);
        }

        public async Task DeleteBodyType(int id)
        {
            await _bodyTypeRepository.GetAsync(id);
        }

        public async Task<IEnumerable<BodyType>> GetAll()
        {
            return await _bodyTypeRepository.GetAll();
        }

        public async Task<BodyType> GetBodyTypeById(int id)
        {
            return await _bodyTypeRepository.GetAsync(id);
        }

        public async Task <BodyType> UpdateBodyType(BodyType bodyType)
        {
            return await _bodyTypeRepository.UpdateAsync(bodyType);
        }

    }
}
