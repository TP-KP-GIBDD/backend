using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public class CarOwnerRepository : RepositoryBase<CarOwner>, ICarOwnerRepository
    {
        public CarOwnerRepository(AvtoContext context) : base(context) 
        {}
    }
}
