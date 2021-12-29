using DTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services.Abstracts
{
    public interface IParticipantsService
    {
        Task<IEnumerable<Participants>> GetAll();
        Task<IEnumerable<Participants>> GetParticipantById(int Id);
        Task<IEnumerable<Participants>> GetParticipantByAvtoId(int Id);
        Task<Participants> GetByFullName(string fullname);
        Task<Participants> Create(Participants participant);
        Task<Participants> Update(Participants participant);
        Task Delete(int Id);
    }
}
