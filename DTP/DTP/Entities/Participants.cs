using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTP.Entities
{
    public class Participants
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("AccountId")] //полное имя
        public int AccountId { get; set; }

        [Column("status")] //статус участник либо виновник
        public string Status { get; set; }

    }
}
