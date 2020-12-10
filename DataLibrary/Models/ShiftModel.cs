using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ShiftModel
    {
        public int ShiftID { get; set; }
        public string ShiftRole { get; set; }
        public string ShiftStart { get; set; }
        public string ShiftEnd { get; set; }
        public int EmployeeID { get; set; }
        public string ShiftDate { get; set; }

    }
}
