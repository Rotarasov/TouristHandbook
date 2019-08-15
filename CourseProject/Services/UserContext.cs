using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public class UserContext
    { 
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }

        [Required, MinLength(6), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"[A-z]+", ErrorMessage = "The First Name field can't contain numbers or symbols")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"[A-z]+", ErrorMessage = "The Last Name field can't contain numbers or symbols")]
        public string LastName { get; set; }
    }
}
