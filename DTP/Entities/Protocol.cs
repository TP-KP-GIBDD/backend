using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Entities
{
    public class Protocol
    {
        [Key]
        [Column ("Id")]
        public int Id { get; set; }

        [Column ("identifier")] // индификатор ДТП
        public int identifier { get; set; }

        [Column ("address")] // адрес ДТП 
        public string Address { get; set; }

        [Column ("dateTime")] // дата и время ДТП
        public DateTime dateTime { get; set; }

        [Column ("inspector")] // имя инспектора
        public string Inspector { get; set; }

        [Column ("loginInspector")] // логин
        public string LoginInspector { get; set; }

        [Column ("placeViolationId")] // место ДТП
        [ForeignKey(nameof(PlaceViolation))]
        public int PlaceViolationId { get; set; }
        public virtual PlaceViolation Place { get; set; }

        [Column ("typeViolationId")] // тип нарушения
        [ForeignKey(nameof(TypeViolation))]
        public int TypeViolationId { get; set; }
        public virtual TypeViolation TypeViolation { get; set; }

        [Column ("participantsId")] // участники
        [ForeignKey(nameof(Participants))]
        public int ParticipantsId { get; set; }
        public virtual Participants Participants { get; set; }

        [Column ("violation")] // описание нарушения
        public string Violation { get; set; }
    }
}
