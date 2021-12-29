using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Models
{
    public class InfoResponceUserModel
    {
        public int Id { get; set; }
        public int ResponceUserId { get; set; }
        public string TypeResponce { get; set; }
        public string StatusResponce { get; set; }
        public DateTime DateResponce { get; set; }
    }
}
