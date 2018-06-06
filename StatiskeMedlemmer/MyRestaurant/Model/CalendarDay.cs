using System;

namespace MyRestaurant.Data
{
    public class CalendarDay 
    {
        public int CalendarDayId { get; set; }
        public DateTime OpenAt { get; set; }
        public DateTime CloseAt { get; set; }
        public string OptionalDescription { get; set; }
        public bool OpenForPublic { get; set; }

        public bool IsWeekend {
            get {
                return OpenAt.DayOfWeek == DayOfWeek.Saturday || OpenAt.DayOfWeek == DayOfWeek.Sunday;
            }
        }
    }
    
}
