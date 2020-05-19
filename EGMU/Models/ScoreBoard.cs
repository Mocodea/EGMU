using System;
using System.Collections.Generic;
using System.Text;

namespace EGMU.Models
{
    class Scoreboard : BaseEntity
    {        
        [Required]
        public string Titel { get; set; }        

        public ICollection<Scores> Scores { get; set; }
    }
}
