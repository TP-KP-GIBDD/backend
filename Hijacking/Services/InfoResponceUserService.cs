using Hijacking.Entities;
using Hijacking.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Services
{
    public class InfoResponceUserService : IInfoResponceUserService
    {
        private readonly IInfoResponceUserService _responce;

        public async Task<InfoResponceUser> Create(InfoResponceUser responce)
        {
            return await _responce.Create(responce);
        }

        public async Task Delete(int id)
        {
            await _responce.Delete(id);
        }

        public async Task<IEnumerable<InfoResponceUser>> GetAll()
        {
            return await _responce.GetAll();
        }

        public async Task<InfoResponceUser> GetResponceId(int id)
        {
            return await _responce.GetResponceId(id);
        }

        public async Task<InfoResponceUser> Update(InfoResponceUser responce)
        {
            return await _responce.Update(responce);
        }
    }
}
