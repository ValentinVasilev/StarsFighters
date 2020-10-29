using InfraStructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class Ship
    {
        public Ship()
        {
            this.Items = new HashSet<Item>();
        }

        public int Id { get; set; }

        public int ShipType
        {
            get
            {
                return (int)this.ShipType;
            }
            set => ShipType = (int)(ShipTypes)value;
        }

        public Statistic ShipStatistics { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
