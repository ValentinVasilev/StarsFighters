namespace StarsFighters.Data.Models
{
    public class Reward
    {
        public int Id { get; set; }

        public int? Experiance { get; set; }

        public int? ResourceId { get; set; }

        public Resource Resource { get; set; }

        public int? ItemId { get; set; }

        public Item Item { get; set; }
    }
}
