using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class NotificationModel
    {
        public int ID { get; set; }
        public string NotificationType { get; set; }
        public string NotificationText { get; set; }
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public int ShiftID { get; set; }

    }
}
