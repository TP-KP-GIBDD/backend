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
        [Column ("id")]
        public int Id { get; set; }

        [Column("number_avto")]
        public int NumberAvto { get; set; }

        [Column("vin")]
        public string Vin { get; set; }

        [Column("brand")]
        public string Brand { get; set; }

        [Column("model")]
        public string Model { get; set; }

        [Column("year")]
        public int Year { get; set; }

        [Column("power")]
        public int Power { get; set; }

        [Column("color")]
        public string Color { get; set; }

        [Column("body_type_id")]
        [ForeignKey(nameof(BodyType))]
        public int BodyTypeId { get; set; }

        public virtual BodyType BodyType { get; set; }

        [Column("rudder_id")]
        [ForeignKey(nameof(Rudder))]
        public int RudderId{ get; set; }

        public virtual Rudder Rudder { get; set; }
    }
}
