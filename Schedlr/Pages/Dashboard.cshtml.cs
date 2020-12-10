using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Schedlr.Models;
using static DataLibrary.BusinessLogic.EmployeeProcessor; // new function to add static class ;)
using static DataLibrary.BusinessLogic.ShiftProcessor; // new function to add static class ;)
using static DataLibrary.BusinessLogic.NotificationProcessor;
using NotificationModel = DataLibrary.Models.NotificationModel;

namespace Schedlr.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly ILogger<DashboardModel> _logger;


        public DashboardModel(ILogger<DashboardModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public DataLibrary.Models.EmployeeModel loggedEmployee { get; set; }

        [BindProperty(SupportsGet = true)] // binding to variable to use on front-end
        public List<ShiftModel> Shifts { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<DataLibrary.Models.EmployeeModel> Employees { get; set; }
        [BindProperty]
        public ShiftModel SelectedShift { get; set; }
        public List<ShiftModel> ShiftsToSwap { get; set; }
        public List<NotificationModel> Notifications { get; set; }

        public void OnGet()
        {
            string name = loggedEmployee.FirstName;
            Shifts = LoadShifts(loggedEmployee.EmployeeId); // loading the shifts affiliated with employee's id

            OrganiseNotifications();

        }

        public void OrganiseNotifications()
        {
            Notifications = LoadNotifications(loggedEmployee.EmployeeId); // loading any notifications the user has
            ShiftsToSwap = new List<ShiftModel>();
            foreach (NotificationModel notification in Notifications)
            {
                if (notification.ShiftID != null)
                {
                    ShiftModel shift = LoadShiftByShiftId(notification.ShiftID)[0];
                    ShiftsToSwap.Add(shift);
                }
            }
        }

        // handler for getting all shifts an employee has
        public JsonResult OnPostGetEmployeeShifts(int id)
        {
            Shifts = LoadShifts(id);
            return new JsonResult(Shifts);
        }

        // creating a post for jQuery to send & get data
        public JsonResult OnPostShiftInfo(int id)
        {
            Employees = GetEmployeesOnShift(id);
            return new JsonResult(Employees);
        }


        //handler for getting employees with specified date
        public void OnPostGetAvaliable()
        {
            Employees = GetAvaliableEmployees("08/11/2020");
        }

        // handler for getting all employees
        public JsonResult OnPostGetEmployees()
        {
            Employees = LoadEmployees();
            return new JsonResult(Employees);
        }



        // handler for swapping a shift swap
        public JsonResult OnPostSwapShift(int employeeId, int shiftId, int employeeId2)
        {
            SelectedShift = LoadShiftByShiftId(shiftId)[0];
            UpdateShift(SelectedShift, employeeId);

            return new JsonResult(SelectedShift);
        }

        // handler for rejecting a shift swap
        public JsonResult OnPostRejectSwap(int notificationId)
        {
            DeleteNotification(notificationId);
            return new JsonResult("Notification Deleted");
        }


        // handler for sending a notification
        public JsonResult OnPostSendNotification(int empId, int senderId, string shiftDate, string notificationText, int shiftId)
        {
            Random random = new Random();
            int notificationId = random.Next(0, 1000); // random id between 1 - 1000
            int result;
            if(shiftDate != null)
            {
                result = CreateNotification(notificationId, "Shift Change", notificationText, senderId, empId, shiftId);
            }
            else
            {
               result = 0;
            }
            return new JsonResult(result);
        }

    }
}
 