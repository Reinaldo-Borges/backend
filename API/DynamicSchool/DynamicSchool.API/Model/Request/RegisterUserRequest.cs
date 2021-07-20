﻿using System.ComponentModel.DataAnnotations;

namespace DynamicSchool.API.Model.Request
{
    public class RegisterUserRequest
    {
        [Required(ErrorMessage = "The field {0} is required")]
        [EmailAddress(ErrorMessage = "The field {0} has incorrect value")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field length must be between {2} and {1} characters")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords aren't match")]
        public string ConfirmPassword { get; set; }
    }
}
