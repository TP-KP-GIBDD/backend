using RegistrationAppointService.Models;
using RegistrationAppointService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Repositories.Implimentation
{
    public class ServiceRepository : IRepository<Service, int>
    {
        private AppDBContext context;
        public ServiceRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void Create(Service model)
        {
            context.Services.Add(model);
            context.SaveChanges();
        }

        public Service Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Service Get(int id)
        {
            return context.Services.Find(id);
        }

        public IEnumerable<Service> GetAll()
        {
            return context.Services;
        }

        public void Update(Service model)
        {
            throw new NotImplementedException();
        }
    }
}
