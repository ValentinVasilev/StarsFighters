using Microsoft.AspNetCore.Mvc;

namespace StarsFighters.Controllers
{
    public class AchievementsController : Controller
    {
        public IActionResult Achievements()
        {
            return View();
        }
    }
}
