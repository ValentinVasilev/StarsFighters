using System;
using System.Collections.Generic;
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
        }

        public int Id { get; set; }

        public int Level { get; set; }

        public int Experience { get; set; }

        public Ship ShipType { get; set; }

        public BuildingBuild Buildings { get; set; }

        public ICollection<Resource> Resources { get; set; }

        public ICollection<Achievement> Achievements { get; set; }

        public ICollection<Item> ItemsType { get; set; }

        public ICollection<BuildingBuild> BuildingsType { get; set; }
    }
}
