using DataLibrary.DataAccess;
using DataLibrary.Models;
using System.Collections.Generic;


namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        // function to create new employee
        public static int CreateEmployee(int employeeId, string jobTitle, string firstName, 
            string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                JobTitle = jobTitle,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress

            };

            string sql = @"insert into dbo.Employee (EmployeeId, JobTitle, FirstName, LastName, EmailAddress)
                            values (@EmployeeId, @JobTitle, @FirstName, @LastName, @EmailAddress);";

            return SQLDataAccess.SaveData(sql, data);
        }

        // function to load employee
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, JobTitle, FirstName, LastName, EmailAddress 
                            from dbo.Employee";

            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }


        public static EmployeeModel FindEmployee(string email)
        {
            //string[] data = new string[1];
            string sql = @"select * from dbo.Employee where EmailAddress in @data";

            List<EmployeeModel> loggedEmployee = SQLDataAccess.LoadEmployee<EmployeeModel>(sql, email);

            return loggedEmployee[0];

        }

        public static EmployeeModel FindEmployeeByID(int id)
        {
            string sql = @"select * from dbo.Employee where EmployeeId in @data";

            List<EmployeeModel> foundEmployee = SQLDataAccess.LoadByEmployeeID<EmployeeModel>(sql, id);

            return foundEmployee[0];
        }

        public static List<EmployeeModel> GetEmployeesOnShift(int shiftId)
        {

            List<ShiftModel> shifts = ShiftProcessor.LoadShiftByShiftId(shiftId); // getting the list of shifts happening 
            List<EmployeeModel> employees = new List<EmployeeModel>(); // creating list of employees that are working that shift

            foreach (ShiftModel shift in shifts) // for each shift
            {
                int num = shift.EmployeeID; // employee id associated with each shift
                string sql = @"select * from dbo.Employee where EmployeeId in @data"; // getting employee details

                employees.Add(SQLDataAccess.LoadByEmployeeID<EmployeeModel>(sql, num)[0]); // adding employee to list of employees

            }

            return employees;
        }


        public static List<EmployeeModel> GetAvaliableEmployees(string shiftDate)
        {
            List<ShiftModel> shifts = ShiftProcessor.LoadShiftByShiftDate(shiftDate);
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (ShiftModel shift in shifts)
            {
                int num = shift.EmployeeID;
                string sql = @"select * from dbo.Employee where EmployeeId in @data";
                employees.Add(SQLDataAccess.LoadByEmployeeID<EmployeeModel>(sql, num)[0]);
            }

            return employees;
        }
    }
}
