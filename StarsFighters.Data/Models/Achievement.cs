using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class Achievement
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime EarnedOn { get; set; }

        public bool Completed { get; set; }
    }
}
