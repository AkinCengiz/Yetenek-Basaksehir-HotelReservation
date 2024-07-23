using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete;
public class Guest : BaseEntity
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Phone { get; set; }
	public string Email { get; set; }
	public DateTime DateOfBirth { get; set; }
	public string Address { get; set; }
}
