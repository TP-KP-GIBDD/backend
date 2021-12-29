using DTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services.Abstracts
{
    public interface ITypeViolationService
    {
        Task<IEnumerable<TypeViolation>> GetAll();
        Task<TypeViolation> GetProtocolById(int Id);
        Task<TypeViolation> GetByName(string name);
    }
}
