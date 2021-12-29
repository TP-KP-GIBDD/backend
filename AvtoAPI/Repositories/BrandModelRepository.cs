using AvtoAPI.Entities;
using AvtoAPI.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public class BrandModelRepository : RepositoryBase<BrandModel>, IBrandModelRepository
    {
        public BrandModelRepository(AvtoContext context) : base(context)
        { }
    }
}
