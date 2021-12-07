using RegistrationAppointService.Models;
using RegistrationAppointService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Services.Implimentation
{
    public class RegAppointService : IRegAppointService
    {
        IDateTimeService dateTimeService;
        AppDBContext context;

        public RegAppointService(IDateTimeService dateTimeService, AppDBContext context)
        {
            this.dateTimeService = dateTimeService;
            this.context = context;
        }

        public bool SaveRegistrationService(RegServiceInfo regService)
        {
            ServiceDateTime currentDatetime = context.ServiceDateTimes.Find(regService.DateTimeId);
            if (currentDatetime == null || regService == null)
            {
                return false;
            }

            currentDatetime.IsFree = false;

            //dateTimeService.TakeTime(regService)
            RegistrationService service = new RegistrationService();
            service.Status = "Ожидает выполнение";
            service.ServiceDateTimeId = regService.DateTimeId;
            service.GibddOfficeId = regService.GibddOfficeId;
            service.CarOwnerId = regService.CarOwenerId;
            service.ServiceId = regService.ServiceId;

            context.Add(service);
            context.SaveChanges();
            return true;
        }

        public bool SetStatus(int RegistrationAppointId, string status)
        {
            RegistrationService service = context.RegistrationServices.Find(RegistrationAppointId);

            if (service != null)
            {
                service.Status = status;
                return true;
            }

            return false;
        }
    }
}
