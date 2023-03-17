using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBooking.Models
{
	public class Reservation
	{
		[Key]
        public int BookingID { get; set; }

		[Required]
		public DateTime Date { get; set; }

		[Required]
		public DateTime Time { get; set; }

        public int PartySize { get; set; }

		public string? TableNo {get; set;}

        public bool? Notification { get; set; } = false;

    }
}
