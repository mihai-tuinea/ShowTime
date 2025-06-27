namespace BlazorApp2.Entities
{
    public class Festival
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Band> Bands { get; set; } = [];
        public ICollection<Booking> Bookings { get; set; } = [];
    }
}
