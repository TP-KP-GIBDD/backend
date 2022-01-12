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
        private readonly ITypeFineRepository _typeFineRepository;
        /*private readonly AccountService _accountService;*/

        public FineService(IFineRepository fineRepository, ITypeFineRepository typeFineRepository/*, AccountService accountService*/)
        {
            _fineRepository = fineRepository;
            _typeFineRepository = typeFineRepository;
           /* _accountService] = accountService;*/
        }

        public async Task<Fine> CreateFine(Fine fine)
        {
            /*Account account = new Account();
            account = account.GetById(fine.PersonId);
            EmailSendService.Send(account.Email, account.FirstName, account.LastName, fine.TypeFine, fine.SumaryFine); */
            /*var person = await _accountService.GetById(fine.PersonId);
            if (person == null)
            {
                throw new NullReferenceException(nameof(person));
            }*/

            var typeFine = await _typeFineRepository.GetAsync(fine.TypeFineId);
            if (typeFine == null) 
            {
                throw new NullReferenceException(nameof(typeFine));
            }
            EmailSendService Sms = new EmailSendService();
            /*await Sms.Send($"{Account.Email}", $"{Account.FirstName}", $"{Account.LastName}", $"{typeFine.Name}", fine.SumaryFine);*/

            await Sms.Send("gorbulko_dmitriy@mail.ru", "Dmitriy", "Gorbulko", $"{typeFine.Name}", fine.SumaryFine);
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

        public async Task<IEnumerable<Fine>> GetFineByPersonId(int id)
        {
            return await _fineRepository.GetFineByPersonId(id);
        }
        public async Task<IEnumerable<Fine>> GetFineByAvtoId(int id)
        {
            return await _fineRepository.GetFineByAvtoId(id);
        }
    }
}
