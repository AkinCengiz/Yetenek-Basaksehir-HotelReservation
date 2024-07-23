using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete;
public class Room : BaseEntity
{
	public Guid HotelId { get; set; }
	public Hotel Hotel { get; set; }
	public Guid RoomTypeId { get; set; }
	public RoomType RoomType { get; set; }
	public string Status { get; set; }
}
