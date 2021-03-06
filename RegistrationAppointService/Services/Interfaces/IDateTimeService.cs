using RegistrationAppointService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Services.Interfaces
{
    public interface IDateTimeService
    {
        IEnumerable<ServiceDateTime> GetTimesByDate(string date);
        void TakeTime(int serviceId);
    }
}
