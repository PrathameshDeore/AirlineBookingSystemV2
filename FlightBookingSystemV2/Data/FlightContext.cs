using FlightBookingSystemV2.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightBookingSystemV2.Data
{
    public class FlightContext:DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<JourneyDetail> JourneyDetails { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<AirlineAuthority> AirlineAuthorities { get; set; }
    }
}
