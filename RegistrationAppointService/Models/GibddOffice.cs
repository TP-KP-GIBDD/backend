using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAppointService.Models
{
    public class GibddOffice
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
        // Координаты
        public double Lat { get; set; }

        public double Lon { get; set; }

        //public List<RegistrationService> RegistrationServices { get; set; }
    }
}
