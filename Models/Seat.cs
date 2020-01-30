using System.Collections.Generic;
namespace Booking.API.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int SaloonID { get; set; }
        public Saloon ThisSaloon { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}