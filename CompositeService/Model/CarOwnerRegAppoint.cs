using Registration.Models.Accounts;
using RegistrationAppointService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeService.Model
{
    public class CarOwnerRegAppoint
    {
        public RegistrationService registrationService { get; set; }

        public AccountResponse carOwner { get; set; }
    }
}
