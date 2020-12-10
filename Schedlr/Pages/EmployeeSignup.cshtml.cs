using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Schedlr.Models;
using DataLibrary; // using data library project
using static DataLibrary.BusinessLogic.EmployeeProcessor; // new function to add static class ;)
using System.Configuration;

namespace Schedlr.Pages
{
    [ValidateAntiForgeryToken] // validating the anti forgery token

    public class EmployeeSignupModel : PageModel
    {

        [BindProperty]
        public EmployeeModel Employee { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //if there is something invalid about the values that have been entered
            if (ModelState.IsValid)
            {
                // calling function from Employee Processor (Data Library) to create a new employee row in database
                int RecordsCreated = CreateEmployee(Employee.EmployeeId, Employee.JobTitle, Employee.FirstName,
                    Employee.LastName, Employee.EmailAddress); 
                    

                return RedirectToPage("./Index", new { Employee.FirstName });
            }
            return Page(); // refreshing page

            // Check Model Against Database
            // anonymous object being passed back to index, to welcome the Username
        }
    }
}
