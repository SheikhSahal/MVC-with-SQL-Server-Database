using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC.Models
{
    public class customphonevalidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Phone no is required");
            }
            else
            { 
            
                if (Regex.IsMatch(value.ToString(),@"^\(\d{3}\)\s\d{3}-\d{4}",RegexOptions.IgnoreCase))
                {
                return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("phone is not a correct format (###) ###-####");
                }

            }
        }
    }
}