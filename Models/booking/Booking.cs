
using ADHD.Models.booking;
using ADHD.Models.consultant;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADHD.Models.booking{
    public enum BookingStatus
    {
        BOOKED = 1,
        CANCELED = 2,
        COMPLETED = 3,
        INPROGRESS = 4,
    }

    public enum UnAttendedStatus
    {
        Default = 0,
        Client = 1,
        Consultant = 2
    }

    public enum Duration
    {
        Thirty = 30,
        Sixty = 60
    }

    public record Booking{
        public int Id { get; init; }
        public int UserId { get; init; }
        public User User { get; init; }
        public int ConsultantId { get; init; }
        public Consultant Consultant { get; init; }
        public int ConsultantSessionId { get; init; }
        public ConsultantSession ConsultantSession { get; init; }
        public DateOnly Date { get; init; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public BookingStatus bookingStatus { get; set; }
        public UnAttendedStatus UnAttendedStatus { get; set; }
        public Duration Duration { get; set; }
        public int Discount { get; set; }
        public int TotalAmount { get; set; }
        public ICollection<BookingSession> BookingSessions { get; set; }
        public ICollection<BookingReschedule> BookingReschedules { get; set; }
        public string PatientInfo { get; set; }
    }
    
}