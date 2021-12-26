using DTP.Entities;
using DTP.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Repositories
{
    public class CoordinatesRepository : BaseRepository<Coordinates>, ICoordinatesRepository
    {
        public CoordinatesRepository(ProtocolContext context) : base(context)
        {

        }
    }
}
