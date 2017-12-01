using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker2.Models
{
    public class TimeCard
    {
        public int ID { get; set; }
        public DateTime submissionDate { get; set; }
        public int MondayHours { get; set; }
        public int TuesdayHours { get; set; }
        public int WednesdayHours { get; set; }
        public int ThurdaydayHours { get; set; }
        public int FridayHours { get; set; }
        public int SaturdayHours { get; set; }
        public int SundayHours { get; set; }
    }
}