using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Schedlr.Models
{
    public class EmployeeModel
    {

        public EmployeeModel()
        {

        }

        public EmployeeModel(int id, string jobTitle, string firstName, string lastName, string email)
        {
            EmployeeId = id;
            JobTitle = jobTitle;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            ConfirmEmail = email;
        }
        //Display is modifying how the string is displayed on the User Interface
        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage = "ID must be 6-Digits" )] // the minimum and maximum numbers of a users employee ID
        public int EmployeeId { get; set;}

        //Display is modifying how the string is displayed on the User Interface
        [Display(Name = "Employee Job Title")]
        [Required(ErrorMessage = "Job title is required")]
        public string JobTitle { get; set; }

        //Display is modifying how the string is displayed on the User Interface
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        //Display is modifying how the string is displayed on the User Interface
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        //Display is modifying how the string is displayed on the User Interface
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)] // the data type is an email address
        [Required(ErrorMessage = "Email is required")]
        public string EmailAddress { get; set; }

        //Display is modifying how the string is displayed on the User Interface
        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "Emails must match")] // comparing the email and confirmed email
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)] // the data type is a password
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8-100 characters")] // setting the max and min characters for password
        public string Password { get; set; }

        //Display is modifying how the string is displayed on the User Interface
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)] // the data type is a password
        [Compare("Password", ErrorMessage = "Both passwords must match")] // comparing the email and confirmed email
        public string ConfirmPassword { get; set; }
    }
}
