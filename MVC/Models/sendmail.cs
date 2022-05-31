using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class sendmail
    {
        [Required (ErrorMessage="Name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage="Email is required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is not a correct format")]
        public string Email { get; set; }

        [Required(ErrorMessage="Mobile No is required")]
        public int Mobile { get; set; }

        [Required(ErrorMessage="Message is required")]
        public string Message { get; set; }

        public string send { get; set; }
    }
}