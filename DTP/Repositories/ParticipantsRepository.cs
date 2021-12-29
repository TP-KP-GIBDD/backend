using DTP.Entities;
using DTP.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Repositories
{
    public class ParticipantsRepository : BaseRepository<Participants>, IParticipantsRepository
    {
        public ParticipantsRepository(ProtocolContext context) : base(context)
        {

        }
    }
}
