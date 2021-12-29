using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hijacking.Entities
{
    public class Protocol
    {
        [Key]
        [Column ("Id")]
        public int Id { get; set; }

        [Column ("namecarowner")]
        public string NameCarowner { get; set; }

        [Column ("datacarownerId")]
        public int DataCarownerId { get; set; }

        [Column ("dateapplication")]
        public DateTime DateApplication { get; set; }

        [Column ("dateacceptance")]
        public DateTime DateAcceptance { get; set; }

        [Column ("avtoId")]
        public int AvtoId { get; set; }

        [Column ("status")]
        public string Status { get; set; }

        [Column ("responcestatmentId")]
        [ForeignKey (nameof(InfoResponceUser))]
        public int Responce { get; set; }
        public virtual InfoResponceUser InfoResponceUser { get; set; }

        [Column ("nameinspector")]
        public string NameInspector { get; set; }

        [Column ("datainspectorId")]
        public int DataInspectorId { get; set; }
    }
}
