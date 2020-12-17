using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarsFighters.Data;

using System.Linq;
using System.Threading.Tasks;
using StarsFighters.Services.Models.Account;
using StarsFighters.Services.Models;
using StarsFighters.Web.ViewModels.Account;
using System.Security.Claims;

namespace StarsFighters.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IAccountService accountService;
        private readonly ApplicationDbContext db;

        public UsersController(IUserService userService, IAccountService accountService, ApplicationDbContext db)
        {
            this.userService = userService;
            this.accountService = accountService;
            this.db = db;
        }

        //public IActionResult Register(AccountInformationViewModel model)
        //{
        //    ClaimsPrincipal currentUser = this.User;

        //    var currentUseId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

        //    if (ModelState.IsValid)
        //    {
        //        var accountOnSignIn = new AccountInformationViewModel();
        //        accountOnSignIn.AspUserId = currentUseId;
        //        accountOnSignIn.Experience = 0;
        //        accountOnSignIn.Level = 1;
        //        accountOnSignIn.ShipType = 0;
        //    }

        //    return RedirectToAction("/Home/Home");
        //}
        //public async Task<IActionResult> Register()
        //{
        //    if (this.userService.GetUserId())
        //    {
        //        return this.View(); //TODO view to redirect to
        //        //Tocheck if user is available 
        //    }

        //    await 
        //}
        //[HttpPost]
        //public HttpResponse Login(RegisterInputModel inputModel)
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        return Redirect("/Home/TestView");
        //    }

        //    return this.View();
        //}
    }
}
