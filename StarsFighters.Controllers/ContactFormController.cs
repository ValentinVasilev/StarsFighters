using Microsoft.AspNetCore.Mvc;
using StarsFighters.Data;
using StarsFighters.Data.Models;
using StarsFighters.Web.ViewModels.ContactForm;
using System;
using System.Security.Claims;

namespace StarsFighters.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly ApplicationDbContext db;

        public ContactFormController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult ContactForm()
        {
            var viewModel = new ContactFormViewModel();
            
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel input)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);

            if (this.ModelState.IsValid)
            {
                var newAccount = new Account
                {
                    AspUserId = userId,
                    Experience = 1,
                    Level = 0,
                };

                return this.View();
            }

            var contact = new ContactForm
            {
                UserId = userId,
                Email = input.Email,
                Account = input.Account,
                About = input.About
            };

            this.db.ContactForms.Add(contact);
            this.db.SaveChanges();

            return Redirect("/Home/Home");
            //TODO: Redirect to LoggedIn Home Page
        }
    }
}
