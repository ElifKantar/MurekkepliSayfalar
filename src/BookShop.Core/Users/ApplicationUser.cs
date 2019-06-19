using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Core.Users
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        
        public string Address { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

    }
}
