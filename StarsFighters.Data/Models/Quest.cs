using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarsFighters.Data.Models
{
    public class Quest
    {
        public Quest()
        {
            this.Rewards = new HashSet<Reward>();
        }
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public string Reward { get; set; }

        // This must be in the Reward class ?
        public decimal XpReward { get; set; }

        public bool Repeatable { get; set; }

        [Required]
        public int LevelRequired { get; set; }

        ICollection<Reward> Rewards { get; set; }
    }
}
