﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EGMU.Models
{
    public class Savegame : BaseEntity
    {
        [Required]
        public string JSON { get; set; }
    }
}
