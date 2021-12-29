using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Entities
{
    public class InfoResponceUser
    {
        [Key]
        [Column ("Id")]
        public int Id { get; set; }

        [Column("responceuser")]
        [ForeignKey(nameof(ResponceUser))]
        public int ResponceUserId { get; set; }
        public virtual ResponceUser ResponceUser { get; set; }

        [Column("typeresponce")]
        public string TypeResponce { get; set; }

        [Column("statusresponce")]
        public string StatusResponce { get; set; }

        [Column("dateresponce")]
        public DateTime DateResponce { get; set; }
    }
}
