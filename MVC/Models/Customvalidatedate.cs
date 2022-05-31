using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Customvalidatedate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Date is required");
            }
            else
            {
                DateTime tem;
                bool Datecorrect = DateTime.TryParse(value.ToString(), out tem);

                if (Datecorrect)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Date is not in correct Format");
                }

            }
        }
    }
}