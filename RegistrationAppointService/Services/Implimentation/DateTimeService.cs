using RegistrationAppointService.Models;
using RegistrationAppointService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Services.Implimentation
{
    public class DateTimeService : IDateTimeService
    {
        AppDBContext context;
        public DateTimeService(AppDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<ServiceDateTime> GetTimesByDate(string _date)
        {

            DateTime date = DateTime.Parse(_date);

            return context.ServiceDateTimes.Where(p => p.Date == date);
        }

        public void TakeTime(int serviceId)
        {
            var service = context.RegistrationServices.Find(serviceId);

            if (service == null)
            {
                throw new Exception($"Сервис с id {serviceId} не существует");
            }
            else
            {
                context.ServiceDateTimes.Find(service.ServiceDateTimeId).IsFree = false;
            }   
        }
    }
}
