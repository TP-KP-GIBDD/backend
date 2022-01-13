using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Models
{
    public class ProtocolResponce
    {
/*        #region coordinates
        // сущность координат
        public int Latitube { get; set; }

        public int Longitube { get; set; }
        #endregion

        #region placeviolation
        // сущность места ДТП

        public string TypeLighting { get; set; }

        public string RoadSigns { get; set; }

        public string MethodTrafficRegulation { get; set; }

        public string RoadMarkup { get; set; }
        #endregion

        #region participants
        // сущность участника
        public string FullName { get; set; }

        public string Status { get; set; }

        public string Login { get; set; }

        public int AvtoId { get; set; }

        public string Damage { get; set; }
        #endregion
*/
        #region protocol
        // сущность протокол
        public int Id { get; set; }

        public int identifier { get; set; }

        public string Address { get; set; }

        public DateTime dateTime { get; set; }

        public string Inspector { get; set; }

        public string LoginInspector { get; set; }

        public int PlaceViolationId { get; set; }

        public int TypeViolationId { get; set; }

        public int ParticipantsId { get; set; }

        public string Violation { get; set; }
    #endregion
}
}
