using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAppointService.Models
{
    public class ServiceDateTime
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public bool IsFree { get; set; }

    }
}
