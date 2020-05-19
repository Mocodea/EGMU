using System;
using System.Collections.Generic;
using System.Text;

namespace EGMU.Models
{
    class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
