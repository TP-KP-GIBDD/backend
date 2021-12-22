using RegistrationAppointService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Services.Interfaces
{
    public interface IRegAppointService
    {
        bool SaveRegistrationService(RegServiceInfo regService);
        IEnumerable<RegistrationService> GetAllRegAppoints();
        IEnumerable<RegistrationService> GetRegAppointById(int id);
        IEnumerable<RegistrationService> GetRegAppointsByCarOwnerId(int id);
        bool SetRegAppointStatus(int regAppointId, string status);
    }
}
