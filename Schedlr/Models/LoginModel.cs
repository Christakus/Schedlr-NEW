using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schedlr.Models
{
    public class LoginModel
    {

        [Display(Name = "Email")]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
