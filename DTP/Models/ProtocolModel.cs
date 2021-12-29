using System;

namespace DTP.Models
{
    public class ProtocolModel
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public DateTime dateTime { get; set; }

        public string Inspector { get; set; }

        public string LoginInspector { get; set; }

        public int PlaceViolationId { get; set; }

        public int TypeViolationId { get; set; }

        public int ParticipantsId { get; set; }

        public string Violation { get; set; }
    }
}
