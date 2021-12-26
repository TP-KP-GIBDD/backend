using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Entities
{
    public class Participants
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("fullname")]
        public string FullName { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("login")] 
        public string Login { get; set; }

        [Column("avtoId")]
        [ForeignKey(nameof(Avto))]
        public int AvtoId { get; set; }
        public virtual Avto Avto { get; set; }

        [Column ("damage")]
        public string Damage { get; set; }
    }
}
