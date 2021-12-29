using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IBrandService
    {
        Task<Brand> GetBrandById(int id);
        Task<IEnumerable<Brand>> GetAll();
        Task<Brand> Create(Brand brand);
        Task<Brand> UpdateBrand(Brand brand);
        Task DeleteBrand(int id);
    }
}
