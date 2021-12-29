using AvtoAPI.Entities;
using AvtoAPI.Repositories.Abstracts;
using AvtoAPI.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<Brand> Create(Brand brand)
        {
            return await _brandRepository.Create(brand);
        }

        public async Task DeleteBrand(int id)
        {
            await _brandRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
            return await _brandRepository.GetAll();
        }

        public async Task<Brand> GetBrandById(int id)
        {
            return await _brandRepository.GetAsync(id);
        }

        public async Task<Brand> UpdateBrand(Brand brand)
        {
            return await _brandRepository.UpdateAsync(brand);
        }
    }
}
