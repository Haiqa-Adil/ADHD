using System.ComponentModel.DataAnnotations;

namespace ADHD.Models.booking
{
    public class BookingReschedule
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public DateOnly Date { get; set; }   
        public string SessionIds { get; set; }
        public DateOnly NewDate { get; set; }
        public string NewSessionIds { get; set; }
    }
}
