using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StarsFighters.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Controllers
{
    public class BuildingsController : Controller
    {

        private readonly UserManager<IdentityUser> identityUserManager;

        public BuildingsController(UserManager<IdentityUser> identityUserManager)
        {
            this.identityUserManager = identityUserManager;
        }

        public IActionResult Buildings()
        {
            return this.View();
        }


        public IActionResult BuildingsUpgrade()
        {
            var userId = this.identityUserManager.GetUserId(this.User);

            //var model = this.buildingUpgradeService.GetDetails

            return View();
        }

        public IActionResult Information()
        {
            return View();
        }

        public IActionResult Research()
        {
            return View();
        }
    }
}
