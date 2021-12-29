using Hijacking.Entities;
using Hijacking.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Repositories
{
    public class InfoResponceUserRepository : BaseRepository<InfoResponceUser>, IInfoResponceUserRepository
    {
        public InfoResponceUserRepository(HijackingContext context): base(context)
        {

        }
    }
}
