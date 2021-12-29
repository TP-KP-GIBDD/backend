using Hijacking.Entities;
using Hijacking.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Repositories
{
    public class ResponceUserRepository : BaseRepository<ResponceUser>, IResponceUserRepository
    {
        public ResponceUserRepository(HijackingContext context) : base(context)
        {

        }
    }
}
