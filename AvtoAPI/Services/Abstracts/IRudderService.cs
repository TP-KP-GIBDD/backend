using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IRudderService
    {
        Task<Rudder> GetRudderById(int id);
        Task<IEnumerable<Rudder>> GetAll();
        Task<Rudder> Create(Rudder rudder);
        Task<Rudder> UpdateRudder(Rudder rudder);
        Task DeleteRudder(int id);
    }
}
