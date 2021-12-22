using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Models
{
    public class CarOwnerModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int AvtoId { get; set; }
    }
}
