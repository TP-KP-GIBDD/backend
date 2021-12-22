using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public class BodyTypeRepository : RepositoryBase<BodyType> , IBodyTypeRepository
    {
        public BodyTypeRepository(AvtoContext context) : base(context) 
        {}
    }
}
