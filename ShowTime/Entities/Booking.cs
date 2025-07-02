namespace ShowTime.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public string? Email { get; set; } // this will be replaced by user foreign key
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid FestivalId { get; set; }
        public Festival? Festival { get; set; }
        // public Guid UserId { get; set; }
        // public User User { get; set; }
    }
}
