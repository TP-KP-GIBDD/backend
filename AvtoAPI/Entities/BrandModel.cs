using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Entities
{
    [Table("brand_model")]
    public class BrandModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("BrandId")]
        [ForeignKey(nameof(Brand))]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
