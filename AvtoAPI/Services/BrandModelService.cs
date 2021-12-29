using AvtoAPI.Entities;
using AvtoAPI.Repositories.Abstracts;
using AvtoAPI.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services
{
    public class BrandModelService : IBrandModelService
    {
        private readonly IBrandModelRepository _brandModelRepository;

        public BrandModelService(IBrandModelRepository brandModelRepository)
        {
            _brandModelRepository = brandModelRepository;
        }

        public async Task<BrandModel> Create(BrandModel brandModel)
        {
            return await _brandModelRepository.Create(brandModel);
        }

        public async Task DeleteBrandModel(int id)
        {
            await _brandModelRepository.GetAsync(id);
        }

        public async Task<IEnumerable<BrandModel>> GetAll()
        {
            return await _brandModelRepository.GetAll();
        }

        public async Task<BrandModel> GetBrandModelById(int id)
        {
            return await _brandModelRepository.GetAsync(id);
        }

        public async Task<BrandModel> UpdateBrandModel(BrandModel brandModel)
        {
            return await _brandModelRepository.UpdateAsync(brandModel);
        }
    }
}
