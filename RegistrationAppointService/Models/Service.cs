using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAppointService.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string TypeOfService { get; set; }

        public List<Document> Documents { get; set; }
    }
}
