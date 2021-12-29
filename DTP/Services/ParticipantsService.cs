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
        private readonly IParticipantsService _participantsService;

        public async Task<Participants> Create(Participants participant)
        {
            return await _participantsService.Create(participant);
        }

        public async Task Delete(int Id)
        {
            await _participantsService.Delete(Id);
        }

        public async Task<IEnumerable<Participants>> GetAll()
        {
            return await _participantsService.GetAll();
        }

        public async Task<Participants> GetByFullName(string fullname)
        {
            return await _participantsService.GetByFullName(fullname);
        }

        public async Task<IEnumerable<Participants>> GetParticipantById(int Id)
        {
            return await _participantsService.GetParticipantById(Id);
        }

        public async Task<IEnumerable<Participants>> GetParticipantByAvtoId(int Id)
        {
            return await _participantsService.GetParticipantByAvtoId(Id);
        }

        public async Task<Participants> Update(Participants participant)
        {
            return await _participantsService.Update(participant);
        }
    }
}
