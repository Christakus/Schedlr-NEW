using DataLibrary.DataAccess;
using DataLibrary.Models;
using System.Collections.Generic;
namespace DataLibrary.BusinessLogic
{
    public static class NotificationProcessor
    {

        public static int CreateNotification(int notificationId, string notificationType, string notificationText, int senderId, int recipientId, int shiftId)
        {
            NotificationModel notifcation = new NotificationModel
            {
                ID = notificationId,
                NotificationType = notificationType,
                NotificationText = notificationText,
                SenderID = senderId,
                RecipientID = recipientId,
                ShiftID = shiftId
            };

            string sql = @"insert into dbo.Notification (ID, NotificationType, NotificationText, SenderID, RecipientID, ShiftID)
                            values (@ID, @NotificationType, @NotificationText, @SenderID, @RecipientID, @ShiftID);";

            return SQLDataAccess.SaveData(sql, notifcation);
        }


        public static List<NotificationModel> LoadNotifications(int id)
        {
            string sql = @"select * from dbo.Notification where RecipientID in @data";

            List<NotificationModel> loadedNotifications = SQLDataAccess.LoadShifts<NotificationModel>(sql, id);

            return loadedNotifications; 
        }

        public static NotificationModel LoadNotification(int id)
        {
            string sql = @"select * from dbo.Notification where ID in @data";

            NotificationModel notificationModel = SQLDataAccess.LoadNotifications<NotificationModel>(sql, id)[0];

            return notificationModel;
        }

        public static void DeleteNotification(int id)
        {
            string sql = @"delete from dbo.Notification where ID = @data"; // deleting specified notification
           SQLDataAccess.DeleteNotification(sql, id);
        }
    }

   
}
