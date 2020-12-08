using System.Threading.Tasks;
using StarsFighters.Web.ViewModels.ContactForm;
using StarsFighters.Data;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace StarsFighters.Services.Models.ContactForm
{
    public class ContactFormService
    {
        private readonly ApplicationDbContext dbContext;

        public ContactFormService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task CreateAsync(ContactFormViewModel contactFormViewModel, string email, string account, string about)
        {
        //    var userId = User
        //    var submitConcat = new ContactFormViewModel
        //    {
        //        About = about,
        //        Account = account,
        //        Email = email,
        //        UserId

        //    };

        //    return await submmitContact;
        }
    }
}
