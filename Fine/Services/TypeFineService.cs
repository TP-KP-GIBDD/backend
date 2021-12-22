using FineAPI.Entities;
using FineAPI.Repositories.Abstract;
using FineAPI.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services
{
    public class TypeFineService : ITypeFineService
    {
        private readonly ITypeFineRepository _typeFineRepository;

        public TypeFineService(ITypeFineRepository typeFineRepository)
        {
            _typeFineRepository = typeFineRepository;
        }

        public async Task<TypeFine> CreateTypeFine(TypeFine typeFine)
        {
            return await _typeFineRepository.Create(typeFine);
        }

        public async Task DeleteTypeFine(int id)
        {
            await _typeFineRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TypeFine>> GetTypeFines()
        {
            return await _typeFineRepository.GetAll();
        }

        public async Task<TypeFine> GetTypeFineById(int id)
        {
            return await _typeFineRepository.GetAsync(id);
        }

        public async Task<TypeFine> UpdateTypeFine(TypeFine typeFine)
        {
            return await _typeFineRepository.UpdateAsync(typeFine);
        }
    }
}
