﻿using LMS.Models;

namespace LMS.DTOS.Users
{
    public class UserDTO
    {
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
 
        public string Role { get; set; }
        public string? PasswordHash { get; set; }

        public int Batch { get; set; }
    }
}
