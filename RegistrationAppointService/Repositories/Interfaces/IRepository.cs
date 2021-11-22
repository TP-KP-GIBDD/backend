using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Repositories.Interfaces
{
    interface IRepository<TDbModel, T>
    {
        public List<TDbModel> GetAll();
        public TDbModel Get(T id);
        public TDbModel Create(TDbModel model);
        public TDbModel Update(TDbModel model);
        public bool Delete(T id);
    }
}
