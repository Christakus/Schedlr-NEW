using System.Collections.Generic;
using DataLibrary.DataAccess;
using DataLibrary.Models;


namespace DataLibrary.BusinessLogic
{
    public static class ShiftProcessor
    {
        // Create new shift
        public static int CreateShift(int shiftId, string shiftRole, string shiftStart, 
            string shiftEnd, int empId, string shiftDate)
        {

            ShiftModel data = new ShiftModel
            {
                ShiftID = shiftId,
                ShiftRole = shiftRole,
                ShiftStart = shiftStart,
                ShiftEnd = shiftEnd,
                EmployeeID = empId,
                ShiftDate = shiftDate
            };

            string sql = @"insert into dbo.Shifts (ShiftId, ShiftRole, ShiftStart, ShiftEnd, EmployeeId, ShiftDate)
                            values (@ShiftID, @ShiftRole, @ShiftStart, @ShiftEnd, @EmployeeID, @ShiftDate);";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<ShiftModel> LoadShifts(int id)
        {
           
            string sql = @"select * from dbo.Shifts where EmployeeId in @data";

            List<ShiftModel> loadedShifts = SQLDataAccess.LoadShifts<ShiftModel>(sql, id);

            return loadedShifts;

        }

        public static List<ShiftModel> LoadShiftByShiftId(int shiftId)
        {

            string sql = @"select * from dbo.Shifts where ShiftId in @data";

            List<ShiftModel> loadedShifts = SQLDataAccess.LoadShifts<ShiftModel>(sql, shiftId);

            return loadedShifts;

        }

        public static List<ShiftModel> LoadShiftByShiftDate(string shiftDate)
        {
            string sql = @"select * from dbo.Shifts where ShiftId @data";
            List<ShiftModel> loadedShifts = SQLDataAccess.LoadShifts<ShiftModel>(sql, shiftDate);

            return loadedShifts;
        }

        public static void UpdateShift(ShiftModel shift, int id)
        {
            SQLDataAccess.UpdateShift(shift, id);
        }
     

    }
}
