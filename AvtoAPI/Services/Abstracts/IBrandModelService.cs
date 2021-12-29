using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IBrandModelService 
    {
        Task<BrandModel> GetBrandModelById(int id);
        Task<IEnumerable<BrandModel>> GetAll();
        Task<BrandModel> Create(BrandModel brandModel);
        Task<BrandModel> UpdateBrandModel(BrandModel brandModel);
        Task DeleteBrandModel(int id);
    }
}
