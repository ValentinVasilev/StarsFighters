using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Controllers
{
    public class BuildingsController : Controller
    {
        public IActionResult Buildings()
        {
            return this.View();
        }


        public IActionResult BuildingsUpgrade()
        {
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
