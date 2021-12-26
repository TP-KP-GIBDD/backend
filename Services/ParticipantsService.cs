using DTP.Entities;
using DTP.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services
{
    public class ParticipantsService : IParticipantsService
    {
        private readonly IParticipantsService _articipantsService;

        public async Task<Participants> Create(Participants participant)
        {
            return await _articipantsService.Create(participant);
        }

        public async Task Delete(int Id)
        {
            await _articipantsService.Delete(Id);
        }

        public async Task<IEnumerable<Participants>> GetAll()
        {
            return await _articipantsService.GetAll();
        }

        public async Task<Participants> GetByFullName(string fullname)
        {
            return await _articipantsService.GetByFullName(fullname);
        }

        public async Task<Participants> GetParticipantById(int Id)
        {
            return await _articipantsService.GetParticipantById(Id);
        }

        public async Task<Participants> Update(Participants participant)
        {
            return await _articipantsService.Update(participant);
        }
    }
}
