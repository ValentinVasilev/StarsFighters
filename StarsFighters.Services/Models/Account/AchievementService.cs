using StarsFighters.Web.ViewModels.Achievements;
using StarsFighters.Data;
using StarsFighters.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StarsFighters.Services.Models.Account
{
    public class AchievementService : IAchievementService
    {
        private readonly ApplicationDbContext dbContext;

        public AchievementService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateAchievement(CreateAchievementViewModel achievementCreateModel)
        {
            var achievement = new Achievement()
            {
                Id = achievementCreateModel.Id,
                Name = achievementCreateModel.Name,
                Description = achievementCreateModel.Description,
                EarnedOn = DateTime.UtcNow,
                Completed = false
                
            };

            this.dbContext.Achievements.Add(achievement);
            this.dbContext.SaveChanges();

        }

        public void GetAllCompleted()
        {
            var completedAchievements = this.dbContext.Achievements.All(x => x.Completed == true);
            
        }

        
    }
}
