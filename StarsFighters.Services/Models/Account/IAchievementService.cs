using System;
using StarsFighters.Web.ViewModels.Achievements;

namespace StarsFighters.Services.Models.Account
{
    public interface IAchievementService
    {
        void CreateAchievement(AchievementCreateModel achievementCreateModel);
        void GetAllAchievements(string accountId, string username);
    }
}
