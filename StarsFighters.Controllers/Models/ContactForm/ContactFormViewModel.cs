using System;
using System.ComponentModel.DataAnnotations;

namespace StarsFighters.Controllers.Models.ContactForm
{
    public class ContactFormViewModel
    {
        public string UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]

        public string Account { get; set; }

        [Required]
        [MaxLength]
        public string About { get; set; }

        public DateTime SubmitedOn => DateTime.UtcNow;
    }
}
