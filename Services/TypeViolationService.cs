using DTP.Entities;
using DTP.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services
{
    public class TypeViolationService : ITypeViolationService
    {
        public readonly ITypeViolationService _typeViolationService;

        public async Task<IEnumerable<TypeViolation>> GetAll()
        {
            return await _typeViolationService.GetAll();
        }

        public async Task<TypeViolation> GetByName(string name)
        {
            return await _typeViolationService.GetByName(name);
        }

        public async Task<TypeViolation> GetProtocolById(int Id)
        {
            return await _typeViolationService.GetProtocolById(Id);
        }
    }
}
