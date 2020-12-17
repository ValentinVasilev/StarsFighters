using Microsoft.AspNetCore.Mvc;
using StarsFighters.Data;
using StarsFighters.Services.Models.Account;
using StarsFighters.Web.ViewModels.Achievements;
using System.Linq;

namespace StarsFighters.Controllers
{
    public class AchievementsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IAchievementService achievementService;

        public AchievementsController(
            ApplicationDbContext dbContext,
            IAchievementService achievementService)
        {
            this.dbContext = dbContext;
            this.achievementService = achievementService;
        }

        //public IActionResult Achievements()
        //{
        //    return View();
        //}

        public IActionResult Create()
        {
            var viewModel = new CreateAchievementViewModel();
            viewModel.Completed = this.dbContext.Achievements.All(x => x.Completed == true);
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateAchievementViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Completed = this.dbContext.Achievements.All(x => x.Completed == true);
                return this.View();
            }


            this.achievementService.CreateAchievement(input);

            this.TempData["Message"] = "Achievement created successfuly.";

            return this.RedirectToAction("/Home/Home");
        }
    }
}
