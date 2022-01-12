using AvtoAPI.Repositories;
using FineAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Repositories.Abstract
{
    public interface IFineRepository : IRepositoryBase<Fine>
    {
        Task<IEnumerable<Fine>> GetFineByPersonId(int id);
        Task<IEnumerable<Fine>> GetFineByAvtoId(int id);
    }
}
