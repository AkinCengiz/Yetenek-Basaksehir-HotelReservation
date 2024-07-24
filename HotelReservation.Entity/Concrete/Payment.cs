using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete;
public class Payment : BaseEntity
{
	public Guid BookingId { get; set; }
	public decimal Amount { get; set; }
	public DateTime PaymentDate { get; set; }
	public string PaymentMethod { get; set; }
}
