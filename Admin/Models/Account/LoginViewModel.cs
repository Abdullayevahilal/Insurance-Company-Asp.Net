using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email is required ")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage = "Enter at least 6 digit")]
        public string Password { get; set; }

        
        public bool RememberMe { get; set; }
    }
}
