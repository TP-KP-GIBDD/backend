using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Models
{
    public class ResponceUserModel
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime Data { get; set; }
        public string Message { get; set; }
    }
}
