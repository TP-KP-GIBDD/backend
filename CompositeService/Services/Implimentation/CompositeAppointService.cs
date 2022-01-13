using CompositeService.Model;
using CompositeService.Services.Interfaces;
using Registration.Services.Abstracts;
using RegistrationAppointService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeService.Services.Implimentation
{
    public class CompositeAppointService : ICompositeAppointService
    {
        IAccountService accountService;
        IRegAppointService regAppointService;

        public CompositeAppointService()
        {
         
        }

        public List<CarOwnerRegAppoint> GetAllRegAppoint()
        {
            var accounts = accountService.GetAll();
            var regAppoints = regAppointService.GetAllRegAppoints();

            CarOwnerRegAppoint carOwnerRegAppoint = new CarOwnerRegAppoint();
            throw new NotImplementedException();
        }

        public CarOwnerRegAppoint GetRegAppointById(int id)
        {
            var regAppoint = regAppointService.GetRegAppointById(id);
            var account = accountService.GetById(regAppoint.CarOwnerId);
            
            CarOwnerRegAppoint carOwnerRegAppoint = new CarOwnerRegAppoint();
            carOwnerRegAppoint.carOwner = account;
            carOwnerRegAppoint.registrationService = regAppoint;

            return carOwnerRegAppoint;
        }
    }
}
