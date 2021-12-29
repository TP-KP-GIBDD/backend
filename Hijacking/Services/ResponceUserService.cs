using Hijacking.Entities;
using Hijacking.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Services
{
    public class ResponceUserService : IResponceUserService
    {
        private readonly IResponceUserService _responceUser;

        public async Task<ResponceUser> Create(ResponceUser responce)
        {
            return await _responceUser.Create(responce);
        }

        public async Task Delete(int id)
        {
            await _responceUser.Delete(id);
        }

        public async Task<IEnumerable<ResponceUser>> GetAll()
        {
            return await _responceUser.GetAll();
        }

        public async Task<ResponceUser> GetResponceId(int id)
        {
            return await _responceUser.GetResponceId(id);
        }

        public async Task<ResponceUser> Update(ResponceUser responce)
        {
            return await _responceUser.Update(responce);
        }
    }
}
