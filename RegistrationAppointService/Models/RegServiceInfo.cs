using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Models
{
    public class RegServiceInfo
    {
        [Required]
        public int CarOwnerId { get; set; }

        public int RegionId { get; set; }

        public int GibddOfficeId { get; set; }

        public int ServiceId { get; set; }

        public int DateTimeId { get; set; }
    }
}
