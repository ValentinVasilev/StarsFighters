using StarsFighters.Web.ViewModels.Achievements;
using StarsFighters.Data;
using StarsFighters.Data.Models;
using System;

namespace StarsFighters.Services.Models.Account
{
    public class AchievementService : IAchievementService
    {
        private readonly ApplicationDbContext dbContext;

        public AchievementService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateAchievement(AchievementCreateModel achievementCreateModel)
        {
            var achievement = new Achievement()
            {
                Id = achievementCreateModel.Id,
                Name = achievementCreateModel.Name,
                Description = achievementCreateModel.Description,
                EarnedOn = achievementCreateModel.EarnedOn

            };

            this.dbContext.Achievements.Add(achievement);
            this.dbContext.SaveChanges();

        }

        public void GetAllAchievements(string accountId, string username)
        {
           
        }
    }
}
