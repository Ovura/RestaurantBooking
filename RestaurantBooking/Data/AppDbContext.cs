using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RestaurantBooking.Data;
using RestaurantBooking.Models;

namespace RestaurantBooking
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public virtual DbSet<Reservation> Bookings { get; set; }
		public virtual DbSet<MemberRegister> MemberResgisters { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }



    }
}
