using InfraStructure.Data.Enums;
using StarsFighters.Data.Models;
using System;

namespace StarsFighters.Services.Models.Buildings
{
    public interface IBuildingService
    {

        void BuildingCost(decimal minerals, decimal crystals, decimal gas);

        void TimeTobeCompleted(TimeSpan time);

        void BuildingProduction(TimeSpan productionTime, decimal minerals, decimal crystals, decimal gas);
    }
}
