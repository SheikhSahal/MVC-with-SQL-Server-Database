using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class PVform
    {
        [Required (ErrorMessage="Name is required")]
        public string Name { get; set; }

        [validateonemail]
        public string Email { get; set; }

        [Required (ErrorMessage="Age is required")]
        [Range(18,50,ErrorMessage="Age Between 18 & 50")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public int Phone { get; set; }
    }
}
