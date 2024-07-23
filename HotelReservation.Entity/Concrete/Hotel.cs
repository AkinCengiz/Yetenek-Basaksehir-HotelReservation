using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete;
public class Hotel : BaseEntity
{
	public string Name { get; set; }
	public string Address { get; set; }
	public string Phone { get; set; }
	public string Email { get; set; }
	public int Star { get; set; }
	public TimeOnly CheckInTime { get; set; }
	public TimeOnly CheckOutTime { get; set; }
	public ICollection<Room>? Rooms { get; set; }
	public ICollection<Staff>? Staffs { get; set; }
}
