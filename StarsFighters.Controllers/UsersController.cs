using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarsFighters.Data;
using StarsFighters.Services.Models;
using System.Linq;
using System.Threading.Tasks;


namespace StarsFighters.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly ApplicationDbContext db;

        public UsersController(IUserService userService, ApplicationDbContext db)
        {
            this.userService = userService;
            this.db = db;
        }


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
