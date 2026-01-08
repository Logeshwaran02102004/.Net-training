using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationDemo.CustomValidation
{
    public class BirthDateValidate : ValidationAttribute

    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime entered_dob = Convert.ToDateTime(value);
            DateTime today = DateTime.Today;
            int age = today.Year - entered_dob.Year;

            if (entered_dob.Date > today.AddYears(-age))
            {
                age--;
            }


            if (age > 21 && age < 25)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}