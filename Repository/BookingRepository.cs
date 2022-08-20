using ADHD.Data;
using ADHD.Middleware;
using ADHD.Models.booking;

namespace ADHD.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private DataContext db;
        public BookingRepository(DataContext db)
        {
            this.db = db;
        }
        public Task<Booking> AddBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> GetBookingById(int bookingId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Booking>> GetBookingForConsultant(int consultantId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Booking>> GetBookingForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> UpdateBookingStatus(int status)
        {
            throw new NotImplementedException();
        }
    }
}
