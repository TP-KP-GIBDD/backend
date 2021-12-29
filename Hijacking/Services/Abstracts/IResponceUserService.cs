using Hijacking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Services.Abstracts
{
    public interface IResponceUserService
    {
        Task<ResponceUser> GetResponceId(int id);
        Task<IEnumerable<ResponceUser>> GetAll();
        Task<ResponceUser> Create(ResponceUser responce);
        Task<ResponceUser> Update(ResponceUser responce);
        Task Delete(int id);
    }
}
