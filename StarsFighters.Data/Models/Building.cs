using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarsFighters.Data.Models
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string BuildingName { get; set; }

        public int CurrentLevel { get; set; }

        public bool UpgradeOnGoing { get; set; }

        public TimeSpan UpgradeEndTime { get; set; }

        public string ResourceName { get; set; }

        public decimal ResourceAmountPerMinute { get; set; }
  
    }
}
