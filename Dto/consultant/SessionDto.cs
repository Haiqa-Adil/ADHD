using ADHD.Models.consultant;

namespace ADHD.Dto.consultant
{
    public class SessionDto
    {
        public DayOfWeek Day { get; set; }
        public ShiftOfDay Shift { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
