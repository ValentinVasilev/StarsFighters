using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarsFighters.Controllers
{
    public class ShipController : Controller
    {
        public IActionResult ShipDeck()
        {

            return this.View();
        }


    }
}
