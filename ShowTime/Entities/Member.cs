namespace ShowTime.Entities
{
    public class Member
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Guid BandId { get; set; }
        public Band? Band { get; set; }

    }
}
