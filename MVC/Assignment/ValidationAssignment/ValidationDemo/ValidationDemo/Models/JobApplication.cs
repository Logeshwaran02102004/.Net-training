using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ValidationDemo.CustomValidation;

namespace ValidationDemo.Models
{
    public class JobApplication
    {
        [Required]
        [DisplayName("Applicant Name")]
        public string name { get; set; }



        [Display(Name = "Years of Experience")]
        [Range(3, 10, ErrorMessage = "Experience must be between 3 and 10 Years")]
        public int experience { get; set; }



        [Required]
        [DisplayName("DOB")]
        [DataType(DataType.Date)]
        [BirthDateValidate(ErrorMessage = "Age must be greater than 21 and less than 25 years")]
        public DateTime birthdate { get; set; }



        [Required]
        [Display(Name = "Email Id")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})$",
            ErrorMessage = "Invalid Email Format")]
        public string email { get; set; }



        [GenderValidate(ErrorMessage = "Please select your correct Gender")]
        public string Gender { get; set; }



      



     

      

        [Required]
        [DisplayName("Date of Joining")]
        [DataType(DataType.Date)]
        [DOJValidate(ErrorMessage = "DOJ must be less than or equal to current date")]
        public DateTime DOJ { get; set; }

        [Required]
        [DisplayName("Password")]
        [PasswordValidate(ErrorMessage = "Password must start with uppercase letter, followed by number, then 6 characters")]
        public string Password { get; set; }

   
    }
}