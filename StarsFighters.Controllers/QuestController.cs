using Microsoft.AspNetCore.Mvc;

namespace StarsFighters.Controllers
{
    public class QuestController : Controller
    {
        public IActionResult Quest()
        {
            return View("Quest");
        }
    }
}
