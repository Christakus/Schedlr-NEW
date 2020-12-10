using System.Collections.Generic;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public class MeetingProcessor
    {
        // Create new meeting
        public static int CreateMeeting(int meetingId, string meetingDate, string meetingTime,
             int empId, string meetingType, string meetingLocation)
        {

            MeetingModel data = new MeetingModel
            {
                MeetingID = meetingId,
                MeetingDate = meetingDate,
                MeetingTime = meetingTime,
                EmployeeID = empId,
                MeetingType = meetingType,
                MeetingLocation = meetingLocation
            };

            string sql = @"insert into dbo.Meeting (MeetingId, MeetingDate, MeetingTime, EmployeeId, MeetingType, MeetingLocation)
                            values (@MeetingID, @MeetingDate, @MeetingTime, @EmployeeID, @MeetingType, @MeetingLocation);";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<MeetingModel> LoadMeetings(int id)
        {

            string sql = @"select * from dbo.Shifts where EmployeeId in @data";

            List<MeetingModel> loadedMeetings = SQLDataAccess.LoadShifts<MeetingModel>(sql, id);

            return loadedMeetings;

        }

        public static List<MeetingModel> LoadMeetingByMeetingId(int meetingId)
        {

            string sql = @"select * from dbo.Meeting where MeetingId in @data";

            List<MeetingModel> loadedMeetings = SQLDataAccess.LoadMeeting<MeetingModel>(sql, meetingId);

            return loadedMeetings;

        }


    }
}
