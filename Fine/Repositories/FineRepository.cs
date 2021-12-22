using FineAPI.Entities;
using FineAPI.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Repositories
{
    public class FineRepository : RepositoryBase<Fine>, IFineRepository
    {
        public FineRepository(FineContext context) : base(context)
        {

        }
    }
}
