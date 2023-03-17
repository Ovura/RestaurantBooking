using System.ComponentModel.DataAnnotations;

namespace RestaurantBooking.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        
        public string Message { get; set; }
    }
}
