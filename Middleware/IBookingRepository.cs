using ADHD.Models.booking;

namespace ADHD.Middleware
{
    public interface IBookingRepository
    {
        Task<List<Booking>> GetBookingForUser(int userId);
        Task<List<Booking>> GetBookingForConsultant(int consultantId);
        Task<Booking> AddBooking(Booking booking);
        Task<Booking> GetBookingById(int bookingId);
        Task<Booking> GetBookingOnDate(DateTime date);
        Task<Booking> UpdateBookingStatus(int status);
    }
}