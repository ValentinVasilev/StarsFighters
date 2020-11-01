using InfraStructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string ItemName { get; set; }

        public ItemTypes ItemType { get; set; }

        public int StatisticsId { get; set; }

        public Statistic Statistics { get; set; }

        [Required]
        public double ItemPrice { get; set; }

        [Required]
        public int ItemMinLevel { get; set; }

        public ItemsQuality ItemQuality { get; set; }
    }
}


