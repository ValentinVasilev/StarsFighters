using Microsoft.AspNetCore.Mvc;
using StarsFighters.Controllers.Models.Account;
using StarsFighters.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarsFighters.Controllers
{
    public class LoggedInController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public LoggedInController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IActionResult AccountInformation()
        {
            var account = new AccountInformationViewModel
            {
                Level = 1,
                Experiance = 100,
                ShipType = 3

            };

            return View(account);
        }
        public IActionResult Achievements()
        {
            return View();
        }

        public IActionResult ShipDeck()
        {
            return View();
        }

        public IActionResult ContactForm()
        {
            return View();
        }
    }
}
