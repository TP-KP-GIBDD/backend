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
        [Column ("CoordinatesId")]
        [ForeignKey(nameof(Coordinates))]
        public int CoordinatesId { get; set; }
        public virtual Coordinates Coordinates { get; set; }
        [Column ("TypeLighting")]
        public string TypeLighting { get; set; }
        [Column ("RoadSigns")]
        public string RoadSigns { get; set; }
        [Column ("MethodTrafficRegulation")]
        public string MethodTrafficRegulation { get; set; }
        [Column ("RoadMarkup")]
        public string RoadMarkup { get; set; }
    }
}
