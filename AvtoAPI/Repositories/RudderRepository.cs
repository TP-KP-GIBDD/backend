using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public class RudderRepository : RepositoryBase<Rudder> , IRudderRepository
    {
        public RudderRepository(AvtoContext context) : base(context) 
        {}
    }
}
