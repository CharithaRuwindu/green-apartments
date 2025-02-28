﻿using Microsoft.AspNetCore.Identity;

namespace Backend.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
    }
}