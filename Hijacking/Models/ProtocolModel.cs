using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Models
{
    public class ProtocolModel
    {
        public int Id { get; set; }
        public string NameCarowner { get; set; }
        public int DataCarownerId { get; set; }
        public DateTime DateApplication { get; set; }
        public DateTime DateAcceptance { get; set; }
        public int AvtoId { get; set; }
        public string Status { get; set; }
        public int Responce { get; set; }
        public string NameInspector { get; set; }
        public int DataInspectorId { get; set; }
    }
}
