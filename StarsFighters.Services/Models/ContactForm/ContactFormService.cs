using System.Threading.Tasks;
using StarsFighters.Web.ViewModels.ContactForm;
using StarsFighters.Data.Models;
using StarsFighters.Data;

namespace StarsFighters.Services.Models.ContactForm
{
    public class ContactFormService
    {
        private readonly ApplicationDbContext dbContext;

        public ContactFormService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task CreateAsync(ContactFormViewModel contactFormViewModel)
        {
           
        }
    }
}
