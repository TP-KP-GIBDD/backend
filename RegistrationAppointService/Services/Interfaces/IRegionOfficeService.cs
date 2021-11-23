using RegistrationAppointService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Services.Interfaces
{
    public interface IRegionOfficeService<T>
    {
        IEnumerable<GibddOffice> GetOfficesByRegionId(T id);
    }
}
