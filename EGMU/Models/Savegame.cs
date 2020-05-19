using System;
using System.Collections.Generic;
using System.Text;

namespace EGMU.Models
{
    class Savegame : BaseEntity
    {
        [Required]
        public string JSON { get; set; }
    }
}
