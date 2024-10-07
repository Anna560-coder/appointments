using Microsoft.EntityFrameworkCore;

namespace SalonStoreMVC.Models
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {

        }
        public DbSet<Bookings> Booking { get; set; }
    }
}
