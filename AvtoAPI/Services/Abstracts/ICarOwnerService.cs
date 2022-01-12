using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface ICarOwnerService
    {
        Task<CarOwner> GetCarOwnerById(int id);
        Task<IEnumerable<CarOwner>> GetAll();
        Task<CarOwner> Create(CarOwner carOwner);
        Task<CarOwner> UpdateCarOwner(CarOwner carOwner);
        Task DeleteCarOwner(int id);
        Task<IEnumerable<CarOwner>> GetCarOwnerByAvtoId(int id);
    }
}
