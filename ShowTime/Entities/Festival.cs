using System.ComponentModel.DataAnnotations;

namespace ShowTime.Entities
{
    public class Festival
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Festival Name must not be empty")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Festival Location must not be empty")]
        public string? Location { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Band> Bands { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
    }
}
