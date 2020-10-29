using System.ComponentModel.DataAnnotations.Schema;

namespace StarsFighters.Data.Models
{
    public class BuildingFormula
    {
        public int Id { get; set; }

        [ForeignKey("Building")]
        public int BuildingId { get; set; }

        public Building Building { get; set; }

        [ForeignKey("Resource")]
        public int ResourceId { get; set; }

        public Resource Resource { get; set; }

        public string UpgradeFormula { get; set; }

        public string ProductionFormula { get; set; }
    }
}
