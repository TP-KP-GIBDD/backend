using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationAppointService.Models
{
    public class ServiceDateTime
    {
        public int Id { get; set; }

        [Column(TypeName="Date")]
        public DateTime Date { get; set; }

        public string Time { get; set; }

        public bool IsFree { get; set; }

    }
}
