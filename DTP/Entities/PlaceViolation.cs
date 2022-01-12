using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Entities
{
    public class PlaceViolation
    {
        [Key]
        [Column ("Id")]
        public int Id { get; set; }

        [Column ("CoordinatesId")] //координаты места ДТП
        [ForeignKey(nameof(Coordinates))]
        public int CoordinatesId { get; set; }
        public virtual Coordinates Coordinates { get; set; }

        [Column ("TypeLighting")] //тип освещения места ДТП
        public string TypeLighting { get; set; }

        [Column ("RoadSigns")] //дорожные знаки
        public string RoadSigns { get; set; }

        [Column ("MethodTrafficRegulation")] //метод регулировки движения на месте ДТП
        public string MethodTrafficRegulation { get; set; }

        [Column ("RoadMarkup")] //дорожная разметка
        public string RoadMarkup { get; set; }
    }
}
