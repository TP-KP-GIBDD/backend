using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Entities
{
    [Table ("type_fine")]
    public class TypeFine
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("article")]
        public string Article { get; set; }
    }
}
