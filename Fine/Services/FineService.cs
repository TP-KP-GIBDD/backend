using FineAPI.Entities;
using FineAPI.Repositories.Abstract;
using FineAPI.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services
{
    public class FineService : IFineService
    {
        private readonly IFineRepository _fineRepository;
        public async Task<Fine> CreateFine(Fine fine)
        {
            /*Person person = new Person();
            person = person.GetById(fine.PersonId);
            EmailSendService.Send(person.Email, person.Name, person.Surname, fine.TypeFine, fine.SumaryFine);*/
            return await _fineRepository.Create(fine);
        }

        public Task DeleteFine(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Fine>> GetFines()
        {
            return await _fineRepository.GetAll();
        }

        public async Task<Fine> GetFineById(int id)
        {
            return await _fineRepository.GetAsync(id);
        }

        public async Task<Fine> UpdateFine(Fine fine)
        {
            return await _fineRepository.UpdateAsync(fine);
        }
    }
}
