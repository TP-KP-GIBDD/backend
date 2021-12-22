using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public interface IAvtoRepository : IRepositoryBase<Avto>
    {
        Task<Avto> GetByNumberAvto(string numberAvto);
    }
}
