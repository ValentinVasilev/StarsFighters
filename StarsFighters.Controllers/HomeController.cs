using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarsFighters.Controllers.Models;
using StarsFighters.Data;

namespace StarsFighters.Controllers
{

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }



        public IActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    return this.Redirect("/Quest");
            //}
            return View();
        }

        public IActionResult Privacy()
        {

            var viewModel = new LoggedInViewModel
            {

                Minerals = this.db.Resources.Count(),
                Metal = this.db.Resources.Count(),
                Gas = this.db.Rewards.Count(),
                Gold = this.db.Ships.Count(),
                StarsCredits = this.db.Quests.Count(),
            };

            return View("TestView", viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
