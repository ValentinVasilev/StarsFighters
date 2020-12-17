﻿using Microsoft.AspNetCore.Mvc;
using StarsFighters.Web.ViewModels.Account;
using StarsFighters.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarsFighters.Web.ViewModels.ContactForm;
using System.Security.Claims;
using StarsFighters.Data.Models;

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
            var accountInfo = new AccountInformationViewModel
            {
                Email = "Someting@abv.bg",
                Experience = 1,
                Level = 1,
                UserName = "Valio",
            };

            return View();
        }
        //public IActionResult Achievements()
        //{
        //    return this.View();
        //}

        public IActionResult ContactForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel input)
        {
            ClaimsPrincipal currentUser = this.User;

            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var contact = new ContactForm
            {
                UserId = currentUserID,
                Email = input.Email,
                Account = input.Account,
                About = input.About,
                Subject = input.Subject,
                SubmitedOn = DateTime.UtcNow
            };

            this.applicationDbContext.ContactForms.Add(contact);
            this.applicationDbContext.SaveChanges();

            return Redirect("/Home/Home");
            //TODO: Redirect to LoggedIn Home Page
        }

    }
}
