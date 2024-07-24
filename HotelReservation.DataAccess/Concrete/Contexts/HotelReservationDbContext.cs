using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.DataAccess.Concrete.Contexts;
public class HotelReservationDbContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(
			@"Data Source=AKINCENGIZ; Initial catalog=HotelReservationDb;Integrated Security=True;Trust Server Certificate=True;");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Staff>().HasData(
			new Staff() {Id = new Guid(), CreateAt = DateTime.Now, }
		);
	}

	public DbSet<Booking> Bookings { get; set; }
	public DbSet<Guest> Guests { get; set; }
	public DbSet<Hotel> Hotels { get; set; }
	public DbSet<Payment> Payments { get; set; }
	public DbSet<Room> Rooms { get; set; }
	public DbSet<RoomType> RoomTypes { get; set; }
	public DbSet<Staff> Staffs { get; set; }
}
