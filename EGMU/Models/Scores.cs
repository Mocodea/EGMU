using System;
using System.Collections.Generic;
using System.Text;

namespace EGMU.Models
{
    class Scores : BaseEntity
    {
        [Required]
        public string Playernmae { get; set; }
        [Required]
        public long Value { get; set; }
      
        public DateTime Date { get; set; }
        
        public string Meta { get; set; }       
    }
}
