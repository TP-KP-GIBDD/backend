using RegistrationAppointService.Models;
using RegistrationAppointService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Repositories.Implimentation
{
    public class RegionRepository : IRepository<Region, int>
    {
        private AppDBContext context;
        public RegionRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void Create(Region model)
        {
            context.Regions.Add(model);
            context.SaveChanges();
        }

        public Region Delete(int id)
        {
            Region region = Get(id);

            if(region != null)
            {
                context.Remove(region);
                context.SaveChanges();
            }

            return region;
        }

        public Region Get(int id)
        {
            return context.Regions.Find(id);
        }

        public IEnumerable<Region> GetAll()
        {
            return context.Regions;
        }

        public void Update(Region model)
        {
            Region currentModel = Get(model.Id);
            currentModel.Name = model.Name;

            context.SaveChanges();
        }
    }
}
