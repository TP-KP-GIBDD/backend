using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationAppointService.Models
{
    public class Region
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public List<GibddOffice> GibddOffices { get; set; }
    }
}
