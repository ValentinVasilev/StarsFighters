using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarsFighters.Services.Models;

namespace StarsFighters.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Login()
        {
            return this.View();
        }
    }
}
