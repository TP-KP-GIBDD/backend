using DTP.Entities;
using DTP.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Repositories
{
    public class PlaceViolationRepository : BaseRepository<PlaceViolation>, IPlaceViolationRepository
    {
        public PlaceViolationRepository(ProtocolContext context) : base(context)
        {

        }
    }
}
