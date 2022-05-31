using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC.Models
{
    public class validateonemail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Email is required");
            }
            else 
            {
                if (Regex.IsMatch(value.ToString(),@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",RegexOptions.IgnoreCase))
                {
                return ValidationResult.Success;
                }
                else
                {
                return new ValidationResult ("Email Format is not valid");
                }

            }
        }
    }
}