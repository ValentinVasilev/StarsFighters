using InfraStructure.Data.Enums;
using StarsFighters.Data.Models;

namespace StarsFighters.Services.Models.Account
{
    public interface IAccountService
    {
        void CreateInitialAccountStatus(int level, decimal xp, ShipTypes shipTypes);

        decimal CreateInitialAccountResources(Resource resource);

        void CreateInitialBuildingsStatus(BuildingTypes buildingTypes, int buildingCurrentLevel, decimal buildingCurrentIncome);

        void ResourcesOnInitialCreate(string username, string email);


        //TODO FutureItem List
    }
}
