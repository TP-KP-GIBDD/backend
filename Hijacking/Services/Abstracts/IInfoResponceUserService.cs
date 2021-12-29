using Hijacking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Services.Abstracts
{
    public interface IInfoResponceUserService
    {
        Task<InfoResponceUser> GetResponceId(int id);
        Task<IEnumerable<InfoResponceUser>> GetAll();
        Task<InfoResponceUser> Create(InfoResponceUser responce);
        Task<InfoResponceUser> Update(InfoResponceUser responce);
        Task Delete(int id);
    }
}
