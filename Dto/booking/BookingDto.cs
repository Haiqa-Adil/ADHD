using ADHD.Models;
using ADHD.Models.booking;

namespace ADHD.Dto.booking
{
    public class BookingDto
    {
        public int UserId { get; init; }
        public int ConsultantId { get; init; }
        public int ConsultantSessionId { get; init; }
        //public DateTime Date { get; init; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public Duration Duration { get; set; }
        public int Discount { get; set; }
        public PersonalInfo PatientInfo { get; set; }
    }
    public class PersonalInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; init; }
        public string ProblemStatement { get; init; }
    }
}
