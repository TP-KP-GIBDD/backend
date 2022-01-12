using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Entities
{
    [Table("fine")]
    public class Fine
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("type_id")]
        [ForeignKey(nameof(TypeFine))]
        [Required]
        public int TypeFineId { get; set; }
        public virtual TypeFine TypeFine { get; set; }

        [Column("person_id")]
        public int PersonId { get; set; }

        [Column("avto_id")]
        public int AvtoId { get; set; }

        [Column ("sumary_fine")]
        [Required]
        public int SumaryFine { get; set; }

        [Column ("status_fine")]
        public string StatusFine { get; set; }
    }
}
