using RegistrationAppointService.Models;
using RegistrationAppointService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Repositories.Implimentation
{
    public class GibddOfficeRepository : IRepository<GibddOffice, int>
    {
        AppDBContext context;

        public GibddOfficeRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void Create(GibddOffice model)
        {
            context.GibddOffices.Add(model);
            context.SaveChanges();
        }

        public GibddOffice Delete(int id)
        {
            GibddOffice office = Get(id);

            if (office != null)
            {
                context.Remove(office);
                context.SaveChanges();
            }

            return office;
        }

        public GibddOffice Get(int id)
        {
            return context.GibddOffices.Find(id);
        }

        public IEnumerable<GibddOffice> GetAll()
        {
            return context.GibddOffices;
        }

        public void Update(GibddOffice model)
        {
            GibddOffice currentModel = Get(model.Id);
            currentModel.Name = model.Name;

            context.SaveChanges();
        }
    }
}
