namespace Booking.API.Models
{
    public class Ticket
    {
        public int UserID { get; set; }
        public int ShowId { get; set; }
        public Show ThisShow { get; set; }
        public int SeatId { get; set; }
        public Seat ThisSeat { get; set; }
    }
}