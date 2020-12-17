using InfraStructure.Data.Enums;
using StarsFighters.Data;
using StarsFighters.Data.Models;
using StarsFighters.Web.ViewModels.Account;

namespace StarsFighters.Services.Models.Account
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext dbContext;

        public AccountService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public decimal CreateInitialAccountResources(AccountResourcesInformationViewModel viewModel)
        {
            var accountResources = new Resource
            {
                Metal = 5000,
                Minerals = 4000,
                Gas = 3000,
                Gold = 1000,
                StarsCredits = 500,
            };

            this.dbContext.Resources.Add(accountResources);
            return this.dbContext.SaveChanges();

        }

        //public void CreateInitialAccountStatus(int level, decimal xp, ShipTypes shipTypes)
        //{
        //    var shipInitialCreate = new Ship
        //    {
        //        ShipType = (int)ShipTypes.Explorer,
        //        ShipStatistics = new Statistic
        //        {
        //            Damage = 1000.00,
        //            HealthPoints = 2000.00,
        //            Shield = 800.00,
        //            HullDamageReduce = 100,
        //            Speed = 200,
        //        },

        //    };

        //    this.dbContext.Ships.Add(shipInitialCreate);
        //    this.dbContext.SaveChanges();

        //}


        public void CreateInitialAccountStatus(AccountInformationViewModel informationViewModel)
        {
            throw new System.NotImplementedException();
        }

        public void CreateInitialBuildingsStatus(BuildingTypes buildingTypes, int buildingCurrentLevel, decimal buildingCurrentIncome)
        {
            throw new System.NotImplementedException();
        }

    }
}
