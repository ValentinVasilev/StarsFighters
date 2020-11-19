using System;

namespace StarsFighters.Web.ViewModels.Achievements
{
    public class AchievementCreateModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime EarnedOn => DateTime.UtcNow;

        public string EarnedOnParsed => EarnedOn.ToString("d");
    }
}
