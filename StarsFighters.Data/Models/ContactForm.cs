using System;
using System.ComponentModel.DataAnnotations;

namespace StarsFighters.Data.Models
{
    public class ContactForm
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public string Email { get; set; }

        public string Account { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string About { get; set; }

        [Required]
        [MaxLength(450)]
        public string Subject { get; set; }

        public DateTime SubmitedOn { get; set; }
    }
}
