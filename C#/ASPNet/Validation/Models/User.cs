using System;
using System.ComponentModel.DataAnnotations;
namespace Validation.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dt;
            //if((DateTime) value >= DateTime.Now) this is my quick method
            if(value is DateTime)
            {
                dt = (DateTime)value;
                //return new ValidationResult("This time has not yet ocurred, please enter valid time!");
            }
            else 
            {
                return new ValidationResult("Invalid datetime");
            }
            if(dt < DateTime.Now)
            {
                return new ValidationResult("Please select a date in the future");
            }
            return ValidationResult.Success;
        }
    }
    public class User 
    {
        [Required]
        [MinLength(4)]
        public string FirstName {get; set;}
        [Required]
        [MinLength(4)]
        public string LastName {get; set;}
        [Required]
        [Range(1, 120)]
        public int Age {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get; set;}
        [Required]
        [FutureDate]
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}
    }
}