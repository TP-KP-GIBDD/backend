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

        [Column ("address")]
        public string Address { get; set; }

        [Column ("dateTime")]
        public DateTime dateTime { get; set; }

        [Column ("inspector")]
        public string Inspector { get; set; }

        [Column ("loginInspector")]
        public string LoginInspector { get; set; }

        [Column ("placeViolationId")]
        [ForeignKey(nameof(PlaceViolation))]
        public int PlaceViolationId { get; set; }
        public virtual PlaceViolation Place { get; set; }

        [Column ("typeViolationId")]
        [ForeignKey(nameof(TypeViolation))]
        public int TypeViolationId { get; set; }
        public virtual TypeViolation TypeViolation { get; set; }

        [Column ("participantsId")]
        [ForeignKey(nameof(Participants))]
        public int ParticipantsId { get; set; }
        public virtual Participants Participants { get; set; }

        [Column ("violation")]
        public string Violation { get; set; }
    }
}
