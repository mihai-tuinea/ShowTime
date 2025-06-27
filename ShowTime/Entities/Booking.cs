namespace ShowTime.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public DateTime Date { get; set; }
        public Guid FestivalId { get; set; }
        public required Festival Festival { get; set; }
        public Guid UserId { get; set; }
        public required User User { get; set; }
    }
}
