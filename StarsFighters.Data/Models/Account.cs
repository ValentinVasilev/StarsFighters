using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class Account
    {
        public Account()
        {
            this.Resources = new HashSet<Resource>();
            this.Achievements = new HashSet<Achievement>();
            this.ItemsType = new HashSet<Item>();
            this.Quests = new HashSet<Quest>();
        }

        public int Id { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public int QuestId { get; set; }

        public Quest Quest { get; set; }

        [Required]
        public Ship ShipType { get; set; }

        public BuildingBuild Buildings { get; set; }

        public ICollection<Resource> Resources { get; set; }

        public ICollection<Achievement> Achievements { get; set; }

        public ICollection<Item> ItemsType { get; set; }

        public ICollection<BuildingBuild> BuildingsType { get; set; }

        public ICollection<Quest> Quests { get; set; }
    }
}
