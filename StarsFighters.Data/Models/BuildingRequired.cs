using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarsFighters.Data.Models
{
    public class BuildingRequired
    {
        public int Id { get; set; }

        [ForeignKey("Building")]
        public int BuildingId { get; set; }

        public Building Building { get; set; }

        [ForeignKey("BuildingRequired")]
        public int BuildingRequiredId { get; set; }

        [Required]
        public int Level { get; set; }
    }
}
