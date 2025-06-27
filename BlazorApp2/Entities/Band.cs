using BlazorApp2.Enums;

namespace BlazorApp2.Entities
{
    public class Band
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Festival> Festivals { get; set; } = [];
    }
}
