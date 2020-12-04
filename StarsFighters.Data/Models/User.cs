using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StarsFighters.Data.Models
{
    public class User : IdentityUser
    {
        public DateTime RegistrationDate => DateTime.UtcNow;

        public bool IsDelete { get; set; }

        [Required]
        public string IpAddress { get; set; }
    }
}
