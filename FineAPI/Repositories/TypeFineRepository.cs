using FineAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Repositories.Abstract
{
    public class TypeFineRepository : RepositoryBase<TypeFine>, ITypeFineRepository
    {
        public TypeFineRepository(FineContext context) : base(context)
        {

        }
    }
}
