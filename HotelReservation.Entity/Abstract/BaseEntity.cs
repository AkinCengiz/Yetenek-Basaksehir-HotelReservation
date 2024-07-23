using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace HotelReservation.Entity.Abstract;
public abstract class BaseEntity
{
	public Guid Id { get; set; }
	public DateTime CreateAt { get; set; }
	public DateTime UpdateAt { get; set; }
	public bool IsActive { get; set; }
}
