using ShowTime.Enums;

namespace ShowTime.Entities
{
    public class Band
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Festival> Festivals { get; set; } = [];
    }
}
