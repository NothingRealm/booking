using System.Collections.Generic;
namespace Booking.API.Models
{
    public class Show
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Summary { get; set; }
        public string Price { get; set; }
        public int SaloonID { get; set; }
        public Saloon ThisSaloon { get; set; }
        public IList<Seat> Seats { get; set; } = new List<Seat>();
    }
}