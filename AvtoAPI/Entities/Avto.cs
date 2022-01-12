using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvtoAPI.Entities
{
    [Table("avto")]
    public class Avto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("number_avto")]
        [Required]
        public string NumberAvto { get; set; }

        [Column("vin")]
        [Required]
        public string Vin { get; set; }

        [Column("person_id")]
        [Required]
        public int PersonId { get; set; }

        [Column("brand_model_id")]
        [ForeignKey(nameof(BrandModel))]
        [Required]
        public int BrandModelId { get; set; }

        public virtual BrandModel BrandModel { get; set; }

        [Column("year")]
        [Required]
        public int Year { get; set; }

        [Column("power")]
        [Required]
        public int Power { get; set; }

        [Column("color_id")]
        [ForeignKey(nameof(Color))]
        [Required]
        public int ColorId { get; set; }

        public virtual ColorAvto Color { get; set; }

        [Column("body_type_id")]
        [ForeignKey(nameof(BodyType))]
        [Required]
        public int BodyTypeId { get; set; }

        public virtual BodyType BodyType { get; set; }

        [Column("rudder_id")]
        [ForeignKey(nameof(Rudder))]
        [Required]
        public int RudderId { get; set; }

        public virtual Rudder Rudder { get; set; }
    }
}
