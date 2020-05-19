using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGMU.Models
{
    public class Scoreboard : BaseEntity
    {
        [Required]
        public string Titel { get; set; }
        public string Description { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}
