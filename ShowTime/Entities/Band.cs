using System.ComponentModel.DataAnnotations;
using ShowTime.Enums;

namespace ShowTime.Entities
{
    public class Band
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        public Genre Genre { get; set; }
        public ICollection<Festival> Festivals { get; set; } = new List<Festival>();
        public ICollection<Member> Members { get; set; } = new List<Member>();
    }
}
