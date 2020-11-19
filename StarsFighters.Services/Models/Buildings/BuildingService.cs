using InfraStructure.Data.Enums;
using StarsFighters.Data;
using StarsFighters.Data.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StarsFighters.Services.Models.Buildings
{
    public class BuildingService : IBuildingService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly BuildingTypes buildingType;

        public BuildingService(ApplicationDbContext dbContext, BuildingTypes buildingType)
        {
            this.dbContext = dbContext;
            this.buildingType = buildingType;
        }

        public void BuildingCost(decimal minerals, decimal crystals, decimal gas)
        {
            //var buildingCost = new Building
            //{
               
            //}
        }

        public decimal BuildingIncome(decimal incomePerMinute)
        {
            return 2.0m;
        }

        public void BuildingProduction(TimeSpan productionTime, decimal minerals, decimal crystals, decimal gas)
        {
            throw new NotImplementedException();
        }

      

        public void TimeTobeCompleted(TimeSpan time)
        {
            throw new NotImplementedException();
        }
    }
}
