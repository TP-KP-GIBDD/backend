using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public int NumberLicense { get; set; }
        public int NumberPasport { get; set; }
        public int AvtoId { get; set; }
    }
}
