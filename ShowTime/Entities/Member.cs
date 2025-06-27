namespace ShowTime.Entities
{
    public class Member
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public Guid BandId { get; set; }
        public required Band Band { get; set; }

    }
}
