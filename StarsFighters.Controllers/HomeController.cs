using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using StarsFighters.Controllers.Models;
using StarsFighters.Data;
using StarsFighters.Web.ViewModels;

namespace StarsFighters.Controllers
{

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;
        private readonly IActionContextAccessor _accessor;
        public IActionContextAccessor Accessor { get; }


        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext db,
            IActionContextAccessor accessor)
        {
            _logger = logger;
            Accessor = accessor;
            this.db = db;
        }



        public IActionResult Index()
        {
            //var userIpAddress = _accessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();
            //TODO : Save current user Ip to Db
            //if (!User.Identity.IsAuthenticated)
            //{
            //    return this.Redirect("/Home/Index");
            //}
            //return RedirectToAction("Home");

            if (User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Home/Home");
            }

            return this.View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult UnderConstruction()
        {
            return this.View("UnderConstruction");
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
