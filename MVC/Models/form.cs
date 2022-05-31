using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVC.Models
{
    public class form
    {
        [Required]
        public string Name { get; set; }

        
        [validateonemail]
        public string Email { get; set; }

        [Required]
        [Range(18 , 50 ,ErrorMessage="Age Enter 18 or 50")]
        public int Age { get; set; }


        [Customvalidatedate]
        public string Date { get; set; }
    }
}