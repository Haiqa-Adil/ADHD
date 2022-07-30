namespace ADHD.Dto.booking
{
    public class BookingRescheduleDto
    {
        public int BookingId { get; set; }
        public DateOnly Date { get; set; }
        public List<int> SessionIds { get; set; }
//        public DateOnly NewDate { get; set; }
        public List<int> NewSessionIds { get; set; }
    }
}
