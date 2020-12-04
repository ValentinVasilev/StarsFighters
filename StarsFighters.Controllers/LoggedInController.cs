using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Controllers
{
    public class LoggedInController : Controller
    {
        public IActionResult Achievements()
        {
            return View();
        }

        public IActionResult ShipDeck()
        {
            return View();
        }
    }
}
