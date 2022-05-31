using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MDataEmp
    {
        [Display(Name="ID :")]
        public int id { get; set; }

        [Required(ErrorMessage="Name is requried")]
        [Display(Name = "Name :")]
        public string Name { get; set; }

        [validateonemail]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile :")]
        public string Mobile { get; set; }

        [Required]
        [Display(Name = "Address :")]
        public string address { get; set; }
    }
}
