using RegistrationAppointService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Repositories.Interfaces
{
    public interface IRepository<TDbModel, T>
    {
        public IEnumerable<TDbModel> GetAll();
        public TDbModel Get(T id);
        public void Create(TDbModel model);
        public void Update(TDbModel model);
        public TDbModel Delete(T id);
    }
}
