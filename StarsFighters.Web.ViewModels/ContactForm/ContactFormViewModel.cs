using System;
using System.ComponentModel.DataAnnotations;

namespace StarsFighters.Web.ViewModels.ContactForm
{
    public class ContactFormViewModel
    {
        public string UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        public string Account { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string About { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(450)]
        public string Subject { get; set; }
        public DateTime SubmitedOn => DateTime.UtcNow;
    }
}
