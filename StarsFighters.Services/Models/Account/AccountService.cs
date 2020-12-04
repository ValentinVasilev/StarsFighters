using InfraStructure.Data.Enums;
using StarsFighters.Data;
using StarsFighters.Data.Models;

namespace StarsFighters.Services.Models.Account
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext dbContext;

        public AccountService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
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

        public void CreateInitialAccountResources(Resource resource)
        {
            var resourcesOnCreation = new Resource
            {
                Metal = 2000,
                Minerals = 1500,
                Gas = 1000,
                Gold = 200,
                StarsCredits = 0
            };

            this.dbContext.Resources.Add(resourcesOnCreation);
            this.dbContext.SaveChanges();
        }

        public void CreateInitialAccountStatus(int level, decimal xp, ShipTypes shipTypes)
        {
            throw new System.NotImplementedException();
        }

        //public void CreateInitialAccountStatus(int level, decimal xp, ShipTypes shipTypes)
        //{
        //    var creatAccountStatus = new InitialAccountStatus 
        //    {
        //        level = 1,
        //        xp = 0,
        //        shipTypes = new Ship { ShipType = (int)ShipTypes.BattleCruiser }
        //    };

        //    this.dbContext.Accounts.Add(creatAccountStatus);
        //    this.dbContext.SaveChanges();
        //}

        public void CreateInitialBuildingsStatus(BuildingTypes buildingTypes, int buildingCurrentLevel, decimal buildingCurrentIncome)
        {
            throw new System.NotImplementedException();
        }

        public void ResourcesOnInitialCreate(string username, string email)
        {
            throw new System.NotImplementedException();
        }

        decimal IAccountService.CreateInitialAccountResources(Resource resource)
        {
            throw new System.NotImplementedException();
        }

        //public void ResourcesOnInitialCreate(string username, string email)
        //{

        //    var resrouncesOnInitialCreate = new Resource
        //    {

        //        Minerals = 1000,
        //        Metal = 1000,
        //        Gas = 650,
        //        Gold = 100,
        //        StarsCredits = 0,

        //    };

        //    this.dbContext.Resources.Add(resrouncesOnInitialCreate);
        //    this.dbContext.SaveChanges();
        //}
    }
}
