using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hijacking.Entities
{
    public class ResponceUser
    {
        [Key]
        [Column ("Id")]
        public int Id { get; set; }

        [Column ("topic")]
        public string Topic { get; set; }

        [Column ("date")]
        public DateTime Data { get; set; }

        [Column ("message")]
        public string Message { get; set; }
    }
}
