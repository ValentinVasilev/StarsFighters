using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarsFighters.Data.Models
{
    public class BuildingBuild
    {
        public int Id { get; set; }


        public int BuildingId { get; set; }

        [Required]
        public double BuildingCost { get; set; }

        [Required]
        public string Requirements { get; set; }

        public decimal EarnPerHour { get; set; }

        [Required]
        public int CurrentLevel { get; set; }

        public bool UpgradeOnGoing { get; set; }

        public TimeSpan UpgradeEndTime { get; set; }

    }
}