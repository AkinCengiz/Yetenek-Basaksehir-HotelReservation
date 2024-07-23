using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete;
public class Booking : BaseEntity
{
	public Guid RoomId { get; set; }
	public Room Room { get; set; }
	public Guid GuestId { get; set; }
	public Guest Guest { get; set; }
	public DateTime CheckIn { get; set; }
	public DateTime CheckOut { get; set; }
	public int NumberOfPeople { get; set; }
	public decimal TotalPrice { get; set; }
	public string Status { get; set; }
}
