using System.ComponentModel.DataAnnotations;

namespace StarsFighters.Data.Models
{
    public class Quest
    {
        //TODO

        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        // ICollection<Reward> ?????
        public string Reward { get; set; }

        // This must be in the Reward class ?
        public decimal XpReward { get; set; }

        public bool Repeatable { get; set; }

        public int LevelRequired { get; set; }
    }
}
