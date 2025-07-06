using System.ComponentModel.DataAnnotations;

namespace ShowTime.Entities
{
    public class FestivalBand
    {
        public Guid FestivalId { get; set; }
        public Festival? Festival { get; set; }

        public Guid BandId { get; set; }
        public Band? Band { get; set; }
        public int Order { get; set; }
    }
}