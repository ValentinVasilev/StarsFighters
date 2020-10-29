using InfraStructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }

        public ItemTypes ItemType { get; set; }

        public int StatisticsId { get; set; }

        public Statistic Statistics { get; set; }

        public double ItemPrice { get; set; }

        public int ItemMinLevel { get; set; }

        public ItemsQuality ItemQuality { get; set; }
    }
}


