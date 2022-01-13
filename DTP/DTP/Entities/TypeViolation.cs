using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Entities
{
    public class TypeViolation
    {
        [Key]
        [Column ("Id")]
        public int Id { get; set; }

        [Column ("name")]
        public string Name { get; set; }
    }
}
