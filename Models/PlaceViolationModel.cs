
namespace DTP.Models
{
    public class PlaceViolationModel
    {
        public int Id { get; set; }

        public string Coordinates { get; set; }

        public string ObjectsAroundRoad { get; set; }

        public string TypeLighting { get; set; }

        public string RoadSigns { get; set; }

        public string MethodTrafficRegulation { get; set; }

        public string RoadMarkup { get; set; }
    }
}
