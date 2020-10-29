using System.ComponentModel.DataAnnotations.Schema;

namespace StarsFighters.Data.Models
{
    public class Building
    {
        public int Id { get; set; }

        public string BuildingName { get; set; }

        public string UpgradeTimeFormula { get; set; }

        [ForeignKey("BuildingBuild")]
        public int BuildingBuildsId { get; set; }

        public BuildingBuild BuildingBuild { get; set; }

        public int BuildingRequiredId { get; set; }
    }
}
