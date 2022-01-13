using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Models
{
    public class ProtocolRequest
    {
        #region coordinates
        // сущность координат
        [Required]
        public double Latitube { get; set; }

        [Required]
        public double Longitube { get; set; }
        #endregion

        #region placeviolation
        // сущность места ДТП

        [Required]
        public string TypeLighting { get; set; }

        [Required]
        public string RoadSigns { get; set; }

        [Required]
        public string MethodTrafficRegulation { get; set; }

        [Required]
        public string RoadMarkup { get; set; }
        #endregion

        #region participants
        // сущность участника
        [Required]
        public int AccountId { get; set; }

        [Required]
        public string Status { get; set; }

        #endregion

        #region protocol
        // сущность протокол
        [Required]
        public int TypeViolationId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime dateTime { get; set; }

        [Required]
        public int InspectorId { get; set; }

        [Required]
        public int AvtoId { get; set; }

        [Required]
        public string Damage { get; set; }


        [Required]
        public string Violation { get; set; }
        #endregion

    }
}
