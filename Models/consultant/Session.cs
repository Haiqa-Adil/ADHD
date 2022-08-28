using ADHD.Models.booking;

namespace ADHD.Models.consultant
{
    public enum ShiftOfDay
    {
        Morning,
        Evening
    }
    public class Session
    {
        public int Id { get; set; }
        public DayOfWeek Day { get; set; }
        public ShiftOfDay Shift { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public ICollection<BookingSession> BookingSessions { get; set; }
    }
}
