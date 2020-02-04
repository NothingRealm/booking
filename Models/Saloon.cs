using System.Collections.Generic;
namespace Booking.API.Models
{
    public class Saloon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short SeatWidht { get; set; }
        public short SeatHeight { get; set; }
		public IList<Seat> Seats { get; set; }
		public IList<Show> Shows { get; set; }
    }
}
