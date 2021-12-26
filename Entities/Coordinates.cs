using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Entities
{
    public class Coordinates
    {
        [Key]
        [Column ("Id")]
        public int Id { get; set; }
        [Column ("Latitude")]
        public int Latitube { get; set; }
        [Column ("Longitube")]
        public int Longitube { get; set; }
    }
}
