﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedlr.Models
{
    public class MeetingModel
    {
      
        public int MeetingID { get; set; }
        public string MeetingDate { get; set; }
        public string MeetingTime { get; set; }
        public int EmployeeID { get; set; }
        public string MeetingType { get; set; }
        public string MeetingLocation { get; set; }

    }
}
