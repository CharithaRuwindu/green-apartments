﻿namespace Backend.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String NormalizedEmail { get; set; }
        public String HashedPassword { get; set; }
        public String Role { get; set; }
        public Boolean EmailVerified { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
