using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Registration.Entities
{
    [Table("users")]
    public class User: BaseEntity
    {

        [Column("name")]
        public string Name { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("phone")]
        public int Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [JsonIgnore]
        [Column("password")]
        public string Password { get; set; }

    }
}
