using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IBodyTypeService
    {
        Task<BodyType> GetBodyTypeById(int id);
        Task<IEnumerable<BodyType>> GetAll();
        Task<BodyType> Create(BodyType bodyType);
        Task<BodyType>UpdateBodyType(BodyType bodyType);
        Task DeleteBodyType(int id);
    }
}
