using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EGMU.Models
{
    public class Score : BaseEntity
    {
        [Required]
        public string Playername { get; set; }
        [Required]
        public long Value { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Meta { get; set; }
        public Guid ScoreboardId { get; set; }

        public Scoreboard Scoreboard { get; set; }
    }
}
