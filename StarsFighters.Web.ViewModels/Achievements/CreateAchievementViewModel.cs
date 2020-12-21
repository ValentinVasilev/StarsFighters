using System;
using System.ComponentModel.DataAnnotations;

namespace StarsFighters.Web.ViewModels.Achievements
{
    public class CreateAchievementViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        public DateTime EarnedOn => DateTime.UtcNow;

        //public string EarnedOnParsed => EarnedOn.ToString("d");

        public bool Completed { get; set; }
    }
}
