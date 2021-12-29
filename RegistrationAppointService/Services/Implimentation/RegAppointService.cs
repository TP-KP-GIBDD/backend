using RegistrationAppointService.Models;
using RegistrationAppointService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RegistrationAppointService.Services.Implimentation
{
    public class RegAppointService : IRegAppointService
    {
        AppDBContext context;

        public RegAppointService(AppDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<RegistrationService> GetAllRegAppoints()
        {
            return context.RegistrationServices
                .Include(rs => rs.GibddOffice)
                    .ThenInclude(g => g.Region)
                .Include(rs => rs.Service)
                    .ThenInclude(s => s.Documents)
                .Include(rs => rs.ServiceDateTime)
                .ToList();

        }
        
        public IEnumerable<RegistrationService> GetRegAppointsByCarOwnerId(int id)
        {
            return context.RegistrationServices
                .Where(rs => rs.CarOwnerId == id)
                .Include(rs => rs.GibddOffice)
                    .ThenInclude(g => g.Region)
                .Include(rs => rs.Service)
                    .ThenInclude(s => s.Documents)
                .Include(rs => rs.ServiceDateTime);
        }

        public RegistrationService GetRegAppointById(int id)
        {
            return context.RegistrationServices
                .Where(rs => rs.Id == id)
                .Include(rs => rs.GibddOffice)
                    .ThenInclude(g => g.Region)
                .Include(rs => rs.Service)
                    .ThenInclude(s => s.Documents)
                .Include(rs => rs.ServiceDateTime)
                .FirstOrDefault();
        }

        public bool SaveRegistrationService(RegServiceInfo regService)
        {
            ServiceDateTime currentDatetime = context.ServiceDateTimes.Find(regService.DateTimeId);
            if (currentDatetime == null || regService == null)
            {
                return false;
            }

            currentDatetime.IsFree = false;

            RegistrationService service = new RegistrationService();
            service.Status = "Ожидает выполнение";
            service.ServiceDateTimeId = regService.DateTimeId;
            service.GibddOfficeId = regService.GibddOfficeId;
            service.CarOwnerId = regService.CarOwnerId;
            service.ServiceId = regService.ServiceId;

            context.Add(service);
            context.SaveChanges();
            return true;
        }

        public bool SetRegAppointStatus(int regAppointId, string status)
        {
            RegistrationService service = context.RegistrationServices.Find(regAppointId);

            if (service != null)
            {
                service.Status = status;
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
