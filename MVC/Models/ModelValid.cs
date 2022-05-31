using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ModelValid
    {
        [Required (ErrorMessage="Name is required")]
        [StringLength (3 , ErrorMessage="Max number is 3 chararcters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is not a correct")]
        public string Email { get; set; }

        [Required(ErrorMessage="Age is Required")]
        [Range (18,50,ErrorMessage="Age Between 18 to 50")]
        public int Age { get; set; }

        [Required(ErrorMessage="Date is required")]
        [DataType(DataType.DateTime,ErrorMessage="data is not")]
        public string Date { get; set; }

    }
}