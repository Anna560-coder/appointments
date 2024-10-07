using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalonSys.Areas.Identity.Data;
using SalonSys.Models;

namespace SalonSys.Data;

public class SalonDbContext : IdentityDbContext<SalonSysUser>
{
    public SalonDbContext(DbContextOptions<SalonDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }


    //public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)

    //{

    //}
    //public DbSet<Booking> Bookings { get; set; }
}
