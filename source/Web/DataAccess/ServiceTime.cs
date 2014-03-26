using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web.DataAccess
{
    public class ServiceTime
    {
        public int Id { get; set; }
        public int ChurchId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
