using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete;
public class RoomType : BaseEntity
{
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal PricePerNight { get; set; }
	public int Capacity { get; set; }
	public ICollection<Room>? Rooms { get; set; }
}
