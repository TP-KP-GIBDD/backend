using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAppointService.Models
{
    public class RegistrationService
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        public int CarOwnerId { get; set; }

        public int GibddOfficeId { get; set; }
        public virtual GibddOffice GibddOffice { get; set; }

        public int ServiceDateTimeId { get; set; }
        public virtual ServiceDateTime ServiceDateTime { get; set; }

        public string Status { get; set; }
    }
}
