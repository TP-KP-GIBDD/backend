using FineAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services.Abstract
{
    public interface IFineService
    {
        Task<Fine> GetFineById(int id);
        Task<IEnumerable<Fine>> GetFines();
        Task<Fine> CreateFine(Fine fine);
        Task<Fine> UpdateFine(Fine fine);
        Task DeleteFine(int id);
        Task<IEnumerable<Fine>> GetFineByPersonId(int id);
        Task<IEnumerable<Fine>> GetFineByAvtoId(int id);
    }
}
