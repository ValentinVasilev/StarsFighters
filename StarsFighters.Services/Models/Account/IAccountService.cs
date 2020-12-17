using InfraStructure.Data.Enums;
using StarsFighters.Data.Models;
using StarsFighters.Web.ViewModels.Account;

namespace StarsFighters.Services.Models.Account
{
    public interface IAccountService
    {
        void CreateInitialAccountStatus(AccountInformationViewModel informationViewModel);

        decimal CreateInitialAccountResources(AccountResourcesInformationViewModel viewModel);

        void CreateInitialBuildingsStatus(BuildingTypes buildingTypes, int buildingCurrentLevel, decimal buildingCurrentIncome);

        //void ResourcesOnInitialCreate(string username, string email);


        //TODO FutureItem List
    }
}
