using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorVotingApp.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter an email address")]
        public string Email { get; set; }
        [Required]  
        public string Password { get; set; }
    }
}
