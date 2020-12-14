using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using StarsFighters.Data;
using StarsFighters.Data.Models;
using StarsFighters.Services.Models.Account;
using StarsFighters.Web.ViewModels.Account;

namespace StarsFighters.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext dbContext;
        private readonly AccountService accountService;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext dbContext)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            this.dbContext = dbContext;

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            [Required]
            [Display(Name = "Username")]
            public string Username { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {

                var user = new IdentityUser { UserName = Input.Username, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    accountCreationOnUserSignin();
                    //ResourcesOnAccountCreation();
                    //accountOnCreation();

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }


                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private void ResourcesOnAccountCreation()
        {

            //var accountId =

            var onAccountCreation = new Resource
            {

                Metal = 2000,
                Minerals = 1000,
                Gas = 500,
                Gold = 100,
                StarsCredits = 0,
            };
            //var accountResourcesOnCreations = new Resource
            //{
            //    //Id = (int)userId,
            //   //TODO: View Model
            //    Metal = 5000,
            //    Minerals = 4000,
            //    Gas = 3000,
            //    Gold = 100,
            //    StarsCredits = 0
            //};


            this.dbContext.Resources.Add(onAccountCreation);
            this.dbContext.SaveChanges();
        }

        private void accountCreationOnUserSignin()
        {
            ClaimsPrincipal currentUser = this.User;

            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            var account = new AccountInformationViewModel
            {
                AspUserId = currentUserID,
                Experience = 0,
                Level = 1,
            };

            //var accountOnCreation = accountService.
            //this.dbContext.Accounts.Add(account);
            //this.dbContext.SaveChanges();
        }

        public void accountOnCreation()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var newAccount = new AccountInformationViewModel
            {
                AspUserId = userId,
                Experience = 0,
                Level = 1,
            };

            //this.dbContext.Accounts.Add(newAccount);
            this.dbContext.SaveChanges();
        }
    }
}

