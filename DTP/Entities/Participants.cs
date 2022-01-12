using AvtoAPI;
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

        [Column("fullname")] //полное имя
        public string FullName { get; set; }

        [Column("status")] //статус участник либо виновник
        public string Status { get; set; }

        [Column("login")] // логин пользователя
        public string Login { get; set; }

        [Column("avtoId")] // данные автомобиля
        [ForeignKey(nameof(Avto))]
        public int AvtoId { get; set; }
        public virtual Avto Avto { get; set; }

        [Column ("damage")] //описание повреждений
        public string Damage { get; set; }
    }
}
