using ADHD.Data;
using ADHD.Middleware;
using ADHD.Models.booking;
using Microsoft.EntityFrameworkCore;

namespace ADHD.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private DataContext db;
        public BookingRepository(DataContext db)
        {
            this.db = db;
        }

        public async Task<Booking> AddBooking(Booking booking)
        {
            await db.Bookings.AddAsync(booking);
            await db.SaveChangesAsync();
            return booking;
        }

        public async Task<Booking> GetBookingById(int bookingId)
        {
            Booking? booking = await db.Bookings.FirstOrDefaultAsync(x => x.Id == bookingId);
            return booking!;
        }

        public async Task<List<Booking>> GetBookingForConsultant(int consultantId)
        {
            var booking = await db.Bookings.Where(x => x.ConsultantId == consultantId && 
                    x.Date >= DateOnly.FromDateTime(DateTime.Now) ).ToListAsync();
            return booking!;
        }

        public Task<List<Booking>> GetBookingForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> GetBookingOnDate(DateTime date)
        {
            var booking = await db.Bookings.FirstOrDefaultAsync
                (x => x.Date == DateOnly.FromDateTime(date));
            return booking!;
        }

        public Task<Booking> UpdateBookingStatus(int status)
        {
            throw new NotImplementedException();
        }
    }
}
