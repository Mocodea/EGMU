using ApplicationCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EGMU.Models
{
	class Game : BaseEntity
	{
			[Required]
			public string Titel { get; set; }        
			public string Description { get; set; }
			public string LogoPath { get; set; }
			public string APIKey { get; set; }

			public ICollection<Scoreboard> Scoreboard { get; set; }
			public ICollection<Savegame> Savegame { get; set; }
	}
}