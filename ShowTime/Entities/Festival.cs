namespace ShowTime.Entities
{
    public class Festival
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Band> Bands { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
    }
}
