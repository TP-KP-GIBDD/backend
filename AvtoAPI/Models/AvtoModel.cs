using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Models
{
    public class AvtoModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }        
        public int Year { get; set; }        
        public int Power { get; set; }        
        public string Color { get; set; }        
        public int BodyTypeId { get; set; }             
        public int RudderId { get; set; }
    }
}
