using FineAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services.Abstract
{
    public interface ITypeFineService
    {
        Task<TypeFine> GetTypeFineById(int id);
        Task<IEnumerable<TypeFine>> GetTypeFines();
        Task<TypeFine> CreateTypeFine(TypeFine typeFine);
        Task<TypeFine> UpdateTypeFine(TypeFine typeFine);
        Task DeleteTypeFine(int id);
    }
}
