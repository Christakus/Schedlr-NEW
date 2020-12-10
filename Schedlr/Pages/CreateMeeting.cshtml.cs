using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Schedlr.Models;
using static DataLibrary.BusinessLogic.MeetingProcessor; // new function to add static class ;)

namespace Schedlr.Pages
{
    public class CreateMeetingModel : PageModel
    {
        [BindProperty]
        public MeetingModel Meeting { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //if there is something invalid about the values that have been entered
            if (ModelState.IsValid)
            {
                // calling function from Employee Processor (Data Library) to create a new employee row in database
                int RecordsCreated = CreateMeeting(Meeting.MeetingID, Meeting.MeetingDate, Meeting.MeetingTime,
                    Meeting.EmployeeID, Meeting.MeetingType, Meeting.MeetingLocation);


                // return RedirectToPage("./Index", new { .FirstName });
            }
            return Page(); // refreshing page

        }
    }
}