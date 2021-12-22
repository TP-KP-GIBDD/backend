using Microsoft.EntityFrameworkCore;
using RegistrationAppointService.Models;
using RegistrationAppointService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Services
{
    public class RegionOfficeService : IRegionOfficeService<int>
    {
        private AppDBContext context;
        public RegionOfficeService(AppDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<GibddOffice> GetOfficesByRegionId(int Id)
        {
            IEnumerable<GibddOffice> offices = context.GibddOffices.Where(p => p.RegionId == Id);

            return offices;
            
        }
    }
}
