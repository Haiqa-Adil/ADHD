using ADHD.Models.consultant;

namespace ADHD.Models.booking
{
    public class BookingSession
    {
        public int SessionId { get; set; }
        public Session Session { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
