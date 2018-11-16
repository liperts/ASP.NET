using System;
using System.Collections.Generic;
// Don't forget to include the following library
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment02.Models
{
    public class Member
    {

        // Using the "Key" attribute to configure a Primary Key. This is necessary to use the Database
        [Key]
        // Using "ID" as a Primary Key
        public int ID { get; set; }

        // Using the "Required" attribute to make this one as a mandatory field 
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        // Thanks Harry for share the regex for Postal Code! \o/
        [RegularExpression(@"(?i)^[a-z][0-9][a-z][]?[0-9][a-z][0-9]", 
            ErrorMessage = "Postal Code must follow the a0a0a0 format, e.g. M6S4T1")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Age")]
        // Using regex to fix a range for age (min e max)
        [RegularExpression("^([1][8-9]|[2-9][0-9]|[1][0-1][0-9]|[1][2][0])$", ErrorMessage = "Age should be an integer between 18 and 120")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Password)]
        // Using the "StringLength" attribute to force that a password must have at least 8 characters long
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [Display(Name = "Password")]
        // We can improve the assignment using regex to force the user to insert a strong password
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", 
            ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        // Using the "Compare" attribute to compare (really?) "Password" and "Confirm Password". Values must be identical
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [EmailAddress]
        [Display(Name = "Alternative Email")]
        public string AlternativeEmail { get; set; }

        [Display(Name = "Phone")]
        public Nullable<int> Phone { get; set; }

    }
}
