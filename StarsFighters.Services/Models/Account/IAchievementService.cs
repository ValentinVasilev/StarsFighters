using System;
using System.Collections.Generic;
using StarsFighters.Web.ViewModels.Achievements;

namespace StarsFighters.Services.Models.Account
{
    public interface IAchievementService
    {
        void CreateAchievement(CreateAchievementViewModel achievementCreateModel);

        void GetAllCompleted();
    }
}
