using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForumSoftware.Models
{
    public class RegisterUserModel
    {
        public RegisterUserModel()
        {
            Reputation = 0;
            JoinDate = DateTime.Now;
        }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string UserName { get; set; }

        // profile
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        public int Reputation { get; set; }
        public string Location { get; set; }

    }
}