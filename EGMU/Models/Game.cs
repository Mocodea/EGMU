using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EGMU.Models
{
    public class Game : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string APIKey { get; set; }

        public ICollection<Scoreboard> Scoreboards { get; set; }
        public ICollection<Savegame> Savegames { get; set; }
    }
}